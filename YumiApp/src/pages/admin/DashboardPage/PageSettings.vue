<template>
   <div>
    <v-toolbar-title class="headline ml-n4">Page Settings</v-toolbar-title>
    <v-card block flat class="shadow">

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
            flat
      
            
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
        
            
        ></v-text-field>
 </v-col>
    </v-row>
</v-list-item>

</v-list>

    <v-divider></v-divider>
<v-list>

  <v-subheader class="title">Content</v-subheader>

<v-list-item>
  <v-row>
  <v-col cols="4">

 <v-subheader>Hero text</v-subheader>
            </v-col>
 <v-col cols="8">
        <v-textarea
            outlined
            label="Type hero text"
         
        
            
        ></v-textarea>
 </v-col>
    </v-row>
</v-list-item>


<v-list-item>
  <v-row>
  <v-col cols="4">

 <v-subheader>Hero Image</v-subheader>
            </v-col>
 <v-col cols="8">
        <v-file-input label="File input" outlined dense></v-file-input>
 </v-col>
    </v-row>
</v-list-item>




<v-list-item>
  <v-row>
  <v-col cols="4">

 <v-subheader>About text</v-subheader>
            </v-col>
 <v-col cols="8">
        <v-textarea
            outlined
            label="Type about text"
         
        
            
        ></v-textarea>
 </v-col>
    </v-row>
</v-list-item>



<v-list-item>
  <v-row>
  <v-col cols="4">

 <v-subheader>About Image</v-subheader>
            </v-col>
 <v-col cols="8">
        <v-file-input label="File input" outlined dense></v-file-input>
 </v-col>
    </v-row>
</v-list-item>



</v-list>
<v-divider></v-divider>

<v-list>

      <v-subheader class="title">Display</v-subheader>



<v-list-item>
  <v-row>
  <v-col cols="4">

 <v-subheader>Carousel items</v-subheader>
            </v-col>
 <v-col cols="8">
      <v-select
          :items="items"
          label="Select"
          dense
          outlined
        ></v-select>
 </v-col>
    </v-row>
</v-list-item>



<v-list-item>
  <v-row>
  <v-col cols="4">

 <v-subheader>Options</v-subheader>
            </v-col>
 <v-col cols="8">
     <v-switch v-model="switch1" :label="`Switch 1: ${switch1.toString()}`"></v-switch>
     <v-switch v-model="switch2" :label="`Switch 2: ${switch2.toString()}`"></v-switch>
 </v-col>
    </v-row>
</v-list-item>










</v-list>
<v-list-item>
    <v-btn color="green accent-3" class="white--text" depressed absolute right @click.stop="dialog = true">Submit</v-btn>
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
    name: 'Settings',
    data() {
        return {
            items: [3, 5, 9],
            switch1: true,
        switch2: false,
        dialog: false,
        }
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