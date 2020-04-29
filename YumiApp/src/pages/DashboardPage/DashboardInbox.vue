<template>
  <div>
    <v-toolbar flat color="transparent">
      <v-toolbar-title class="headline ml-n4">Inbox ({{messages.length}})</v-toolbar-title>
    </v-toolbar>
    
    <v-card class="mb-5">

      <template v-if="loading">
        <AppLoader/>
      </template>

      <template v-else>

        <template v-if="messages.length == 0">
          <NothingToDisplay
          text="No Messages"
          />
        </template>
        
        <template v-else>

          <v-list two-line v-for="(item, index) in messages" :key="index" class="pa-0 ma-0">

            <InboxItem
            :inboxData="messages"
            :item="item"
            :subject="item.subject"
            :name="item.name"
            :comment="item.comment"
            :date="item.dateSent"
            :read="item.isRead"/>

          <v-divider v-if="index + 1 < messages.length" :key="index"></v-divider>
    
          </v-list>

        </template>
      </template>

    </v-card>
  </div>
</template>
<script>
import AppLoader from '@/components/common/AppLoader'
import NothingToDisplay from '@/components/common/NothingToDisplay'
import InboxItem from '@/components/dashboard/InboxItem'

export default {
    name: 'Inbox',
    components: {
      InboxItem,
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
      //Henter data fra API og legger dataen i messages Arrayet
      getMessages(){
      this.init()
      this.loading = true;
      let webAPIUrl = "https://localhost:5001/admin/messages";
      this.$http.get( webAPIUrl )
        .then( response => { 
          this.messages = response.data;
          this.loading = false    
        })       
      },
      //Setter isRead til true og oppdaterer verdien til databasen.
      openMessage(item) {
        if(item.isRead == false) {
          item.isRead = true
          this.isRead(item)
        }
        this.message = Object.assign({}, item)
        this.dialog = true        
      },
      isRead(message){
        let webAPIUrl = "https://localhost:5001/admin/messages/";
        this.$http.put( webAPIUrl, message )
      },
      //Sletter objektet fra messages Arrayet og sletter objektet fra databasen
      deleteMessage(item) {
        const index = this.messages.indexOf(item)
        this.messages.splice(index, 1)
        this.dialog = false;
        let webAPIUrl = `https://localhost:5001/admin/messages/${item.id}`;
        this.$http.delete(webAPIUrl)
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