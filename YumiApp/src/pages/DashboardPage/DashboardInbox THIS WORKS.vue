<template>
  <div>
    


    <v-toolbar flat color="transparent">
      <v-toolbar-title class="headline ml-n4">Inbox ({{messages.length}})</v-toolbar-title>
    </v-toolbar>

     <v-card min-height="500px" class="mb-5">

 <template v-if="loading">
    
      <AppLoader/>

    </template>

    <template v-else>



   <template v-if="messages.length == 0">
            <NothingToDisplay
            text="No Messages"/>
            </template>
              <template v-else>


    <v-list two-line v-for="(item, index) in messages" :key="index" class="pa-0 ma-0">

   
  
          <v-list-item  @click="openMessage(item)">
          <template v-if="!item.isRead">
       <div class="unread mr-5"></div>
      </template>
              <v-list-item-content>
                <v-list-item-title v-text="item.subject"></v-list-item-title>
                <v-list-item-subtitle class="text--primary" v-text="item.name"></v-list-item-subtitle>
                <v-list-item-subtitle v-text="item.subtitle"></v-list-item-subtitle>
              </v-list-item-content>

              <v-list-item-action>
                <v-list-item-action-text v-text="item.dateSent"></v-list-item-action-text>
              </v-list-item-action>

          </v-list-item>

          <v-divider
            v-if="index + 1 < messages.length"
            :key="index"
          ></v-divider>
    

         
    </v-list>
      </template>
          </template>
  </v-card>





    <v-dialog
        v-model="dialog"
        max-width="690"

      >
        <v-card min-height="400px">
<v-sheet color="grey lighten-3">


        <v-list-item>
          <v-card-title class="headline">{{message.subject}}</v-card-title>

        <template v-if="message.contactByPhone">
        <v-row   align="center"
          justify="end">
                 <v-chip
      class="ma-2 white--text"
      color="red"

    >
    <v-icon small class="mr-2">mdi-phone</v-icon>
      Contact by phone
    </v-chip>

        </v-row>
  
        </template>

       </v-list-item>
</v-sheet>
 <v-divider></v-divider>
<v-list-item>
          <v-card-subtitle>
          From:
          {{message.name}}, {{message.email}}, {{message.phoneNumber}}
        </v-card-subtitle>

         <v-row   align="center"
          justify="end">
<v-card-subtitle>Recieved: {{message.dateSent}} </v-card-subtitle>
         </v-row>
        </v-list-item>
 <v-divider></v-divider>

        <v-list-item>


              <v-card-text>
          {{message.comment}}
        </v-card-text>

        </v-list-item>
        <v-card-actions>
  
<div class="buttons-position">

          <v-btn
            color="amber accent-3"
            rounded
            depressed
            @click="dialog = false"
            class="mr-3"
          >
            Cancel
          </v-btn>

          <v-btn
            color="amber accent-3"
            rounded
            depressed
            @click="deleteMessage(message)"
          >
            Delete
          </v-btn>
</div>
        </v-card-actions>

      </v-card>
    </v-dialog>



  </div>
</template>
<script>
import AppLoader from '@/components/common/AppLoader'
import NothingToDisplay from '@/components/common/NothingToDisplay'
export default {
    name: 'Inbox',
        components: {
      AppLoader,
      NothingToDisplay
    },
     data () {
      return {
        loading: true,
        messages: [],
        dialog: false,
        message: {},
        messageIndex: -1,
      }
    },
          methods: {

    init() {
      this.messages = [{}]
    },
     getMessages(){
            this.init()
            this.loading = true;
            let webAPIUrl = "https://localhost:5001/contactmessages";
            this.$http.get( webAPIUrl )
                .then( response => { 
                    this.messages = response.data;
                    this.loading = false    
                })

             
        },
 
        openMessage(item) {
              if(item.isRead == false) {
                item.isRead = true
                this.isRead(item)
              }
              this.message = Object.assign({}, item)
              this.dialog = true
             
      
              
        },
        isRead(message){
            let webAPIUrl = "https://localhost:5001/contactmessages/";
            this.$http.put( webAPIUrl, message )
            console.log("SAVE");
            console.log(message)

    
        },
        deleteMessage(item) {
        const index = this.messages.indexOf(item)
        this.messages.splice(index, 1)
          
          this.dialog = false;
          let webAPIUrl = `https://localhost:5001/contactmessages/${item.id}`;
          this.$http.delete(webAPIUrl)
            .then(
            console.log("Deleted item with ID: " + item.id),

            )
     

            },
  },
  created(){
    this.getMessages()
  }
    

    
}
</script>
<style scoped>
.height {
  height: 100px;
}

.unread {
  border-radius: 100%;
  width: 12px;
  height: 12px;
  background-color: red;
}
.buttons-position {
  position: absolute;
  bottom: 0;
  right: 0;
  padding-bottom: 10px;
  padding-right: 10px;
}
</style>