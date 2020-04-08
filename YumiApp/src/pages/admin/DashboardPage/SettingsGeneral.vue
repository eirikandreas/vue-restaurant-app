<template>
   <div>    <v-toolbar flat color="transparent">
            <v-toolbar-title class="headline ml-n4">Page Settings</v-toolbar-title>
            </v-toolbar>
    <v-card>

<v-row>
<v-col cols="12" md="12" lg="12">
<v-list>
    <v-subheader class="title">General</v-subheader>

    
<v-list-item>
  <v-row>
  <v-col cols="4">

 <v-subheader>Page display name</v-subheader>
            </v-col>
 <v-col cols="8">
        <v-text-field
            dense
            label="Type title"
            outlined
    
            v-model="editPage.pageTitle"
      
            
        ></v-text-field>
 </v-col>
    </v-row>
</v-list-item>

 


<v-list-item>
  <v-row>
  <v-col cols="4">

 <v-subheader>Contact e-mail</v-subheader>
            </v-col>
 <v-col cols="8">
        <v-text-field
            dense
            label="Type your e-mail"
            outlined
            flat
            v-model="editPage.contactEmail"
      
            
        ></v-text-field>
 </v-col>
    </v-row>
</v-list-item>

<v-list-item>
  <v-row>
  <v-col cols="4">

 <v-subheader>Contact phone number</v-subheader>
            </v-col>
 <v-col cols="8">
        <v-text-field
            dense
            label="Type phone number"
            outlined
            flat
            v-model="editPage.contactNumber"
        
            
        ></v-text-field>
 </v-col>
    </v-row>
</v-list-item>


<v-list-item>
  <v-row>
  <v-col cols="4">

 <v-subheader>Contact address</v-subheader>
            </v-col>
 <v-col cols="8">
        <v-text-field
            dense
            label="Type your contact address"
            outlined
            flat
            v-model="editPage.contactAddress"
        
            
        ></v-text-field>
 </v-col>
    </v-row>
</v-list-item>






</v-list>
<v-list-item>
    <v-btn color="green accent-3" class="white--text" depressed absolute right @click.stop="dialog = true">Save</v-btn>
</v-list-item>
    
</v-col>
</v-row>
    </v-card>








    <!-- DIALOG --->

 <v-dialog
      v-model="dialog"
      max-width="600"
    >
      <v-card>
        <v-card-title class="headline">Save changes</v-card-title>

        <v-card-text>
          This will apply changes to the web page settings. Do you want to continue?
        </v-card-text>

        <v-card-actions>
          <v-spacer></v-spacer>

          <v-btn
            color="green accent-3"
            class="white--text"
            depressed
        
            @click="dialog = false"
          >
            Cancel
          </v-btn>

          <v-btn
            color="grey lighten-4"
            depressed
       
            @click="savePageContent()"
          >
            Save
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>




    <!-- DIALOG END -->
       </div>  
</template>
<script>
export default {
    name: 'SettingsGeneral',
    data() {
        return {
            items: [3, 5, 9],
            switch1: true,
        switch2: false,
        dialog: false,
        editPage: {}
        }
    },
     methods: {
       initialize() {
         this.editPage = {}
       },
        getPageContent(){
            let webAPIUrl = "https://localhost:5001/pagecontent/1";
            this.$http.get( webAPIUrl )
                .then( result => {
                    this.editPage = result.data;
                    console.log(this.editPage)
                })
        },
        savePageContent(){
            let webAPIUrl = "https://localhost:5001/pagecontent";
            this.$http.put( webAPIUrl, this.editPage )
            console.log("SAVE");
            this.getPageContent()
            this.dialog = false;
            
        }
    },
    created() {
      this.initialize()
      this.getPageContent()
    }
    
}
</script>
<style scoped>
.shadow {
    -webkit-box-shadow: 0px 0px 50px 0px rgba(238, 238, 238, 9);
    -moz-box-shadow: 0px 0px 50px 0px rgba(238, 238, 238, 9);
    box-shadow: 0px 0px 50px 0px rgba(238, 238, 238, 9);
}
</style>