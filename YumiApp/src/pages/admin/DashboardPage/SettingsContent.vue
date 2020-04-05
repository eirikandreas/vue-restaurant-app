<template>
   <div>    <v-toolbar flat color="transparent">
            <v-toolbar-title class="headline ml-n4">Page Settings</v-toolbar-title>
            </v-toolbar>
    <v-card block flat class="shadow">

<v-row>
<v-col cols="12" md="12" lg="12">
<v-list>

  <v-subheader class="title">Content</v-subheader>

<v-list-item>
  <v-row>
  <v-col cols="4">

 <v-subheader>About Page Text</v-subheader>
            </v-col>
 <v-col cols="8">
        <v-textarea
            outlined
            label="Type about text"
            v-model="editPage.aboutPageText"
         
        
            
        ></v-textarea>
 </v-col>
    </v-row>
</v-list-item>


<v-list-item>
  <v-row>
  <v-col cols="4">

 <v-subheader>About Page Image</v-subheader>
            </v-col>
 <v-col cols="8">
        <v-file-input label="File input" outlined dense></v-file-input>
 </v-col>
    </v-row>
</v-list-item>




<v-list-item>
  <v-row>
  <v-col cols="4">

 <v-subheader>Contact Page Text</v-subheader>
            </v-col>
 <v-col cols="8">
        <v-textarea
            outlined
            label="Type about text"
            v-model="editPage.contactPageText"
         
        
            
        ></v-textarea>
 </v-col>
    </v-row>
</v-list-item>



<v-list-item>
  <v-row>
  <v-col cols="4">

 <v-subheader>Contact Page Image</v-subheader>
            </v-col>
 <v-col cols="8">
        <v-file-input label="File input" outlined dense></v-file-input>
 </v-col>
    </v-row>
</v-list-item>









</v-list>
<v-list-item>
    <v-btn color="green accent-3" class="white--text" depressed absolute right @click.stop="dialog = true">Submit</v-btn>
</v-list-item>

<v-list-item>

    <v-btn color="green accent-3" class="white--text" depressed absolute right @click="savePageContent()">Save</v-btn>
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
        <v-card-title class="headline">Submit changes</v-card-title>

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
       
            @click="dialog = false"
          >
            Submit
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>




    <!-- DIALOG END -->
       </div>  
</template>
<script>
export default {
    name: 'SettingsContent',
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