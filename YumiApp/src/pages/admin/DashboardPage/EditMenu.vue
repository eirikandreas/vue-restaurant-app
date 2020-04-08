<template>
    <div>
        <v-toolbar flat color="transparent">
            <v-toolbar-title class="headline ml-n4">Edit Menu</v-toolbar-title>
    
            <v-spacer></v-spacer>

            <!-- select category -->

            <!-- 
            <div width="100px" class="mt-5 mr-5">
                <v-select :items="items" label="Solo field" solo dense flat width="200px"></v-select>
            </div>
            -->
            <!-- select category end --> 
            <v-dialog :fullscreen="$vuetify.breakpoint.xsOnly" v-model="dialog" max-width="960px" class="mx-auto">
                <template v-slot:activator="{ on }">
                <v-btn depressed color="black" dark class="mb-2 mr-n5" v-on="on">New Item</v-btn>
            </template>

          <v-card block>
            <v-card-title>
              <span class="headline font-weight-bold">{{ formTitle }}</span>
            </v-card-title>
             <v-divider></v-divider>
            <v-card-text>

          
              <v-container>
                <v-row>
                  <v-col cols="12" sm="6" md="4">
                    <v-text-field color="amber accent-3" dense outlined v-model="editedItem.title" label="Title"></v-text-field>

                  </v-col>


       



<v-col cols="12" sm="6" md="4">

      <v-text-field color="amber accent-3" dense outlined v-model="editedItem.price" label="Price"></v-text-field>
</v-col>


<v-col cols="12" md="4">

  <v-select 
  
  dense outlined 
  color="amber accent-3"
          v-model="editedItem.category"
          :items="categories"
          label="Choose category"
        ></v-select>

</v-col>


         </v-row>

         <v-row>

<v-col cols="12" md="6">
        <v-textarea dense outlined
          auto-grow color="amber accent-3" v-model="editedItem.ingredients" label="Description"></v-textarea>


</v-col>


        

<v-col cols="12" md="6">
        <v-textarea dense outlined
          auto-grow color="amber accent-3" v-model="editedItem.ingredients" label="Ingredients"></v-textarea>


</v-col>

         </v-row>


         <v-row>
                  <v-col cols="12" sm="12" md="12">
                    
                    <v-text-field dense outlined color="amber accent-3" v-model="editedItem.allergens" label="Allergens"></v-text-field>
                 
                     

                  </v-col>


         </v-row>

         <v-row>
                    
        <!-- IMAGE UPLOADER -->        
<v-col cols="12" sm="12" md="12">

     <v-file-input id="file" name="file" color="amber accent-3" dense outlined accept="image/*" label="Upload Image" prepend-icon="mdi-camera"></v-file-input> 
</v-col>


                </v-row>



<v-row>
<v-card outlined flat width="100%" class="d-flex align-center">
<v-card-text>
    Add the this Menu Item to the Front Page Carousel by setting it as Featured.

 </v-card-text>
  <v-switch inset v-model="editedItem.isFeatured" color="green lighten-1"></v-switch>
</v-card>

 </v-row>


              </v-container>
            </v-card-text>

            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn color="grey lighten-3" depressed @click="close">Cancel</v-btn>
              <v-btn color="green lighten-1" depressed @click="save">Save</v-btn>
            </v-card-actions>
          </v-card>
        </v-dialog>
      </v-toolbar>
  

<v-card>
 <v-data-table
    :headers="headers"
    :items="menuItems"
    :loading="loading"
    loading-text="Hold on, while we are getting the menu!"
    sort-by="id"
    sort-desc
  
  >


<template v-slot:item.imgUrl="{ item }">
    <v-img class="round-img mt-3 mb-3" :src="`https://localhost:5001/images/${item.imgUrl}`" width="40px" height="40px">
    </v-img>
</template>


<template v-slot:item.title="{ item }">
    <div class="font-weight-bold"> {{ item.title }}</div>
</template>



<template v-slot:item.allergens="{ item }">
    <div class="grey--text"> {{ item.allergens }}</div>
</template>

<template v-slot:item.category="{ item }">
    <div class="grey--text"> {{ item.category }}</div>
</template>

<template v-slot:item.price="{ item }">
    <div class="grey--text"> {{ item.price }}</div>
</template>

<template v-slot:item.timesOrdered="{ item }">
    <v-btn depressed small rounded min-width="60px" :color="getColor(item.timesOrdered)" dark>
        {{ item.timesOrdered }}</v-btn>
</template>

<template v-slot:item.dateAdded="{ item }">
    <div class="grey--text"> {{ item.dateAdded }}</div>
</template>


<template v-slot:item.isFeatured="{ item }">
    
    <!--
    <v-btn depressed small min-width="120px" :color="setFeatured(item.isFeatured)" @click="item.isFeatured = !item.isFeatured">
        {{ item.isFeatured ? 'Is Featured' : 'Set Featured' }}
    </v-btn>

    -->

      <v-switch v-model="item.isFeatured" inset color="green lighten-1"></v-switch>
</template>

<template v-slot:item.actions="{ item }">
    <v-icon :large="$vuetify.breakpoint.xsOnly" class="mr-2" @click="editItem(item)">
        mdi-pencil
    </v-icon>
    <v-icon :large="$vuetify.breakpoint.xsOnly" @click="deleteItem(item)">
        mdi-delete
    </v-icon>
</template>

<template v-slot:no-data>
    <h1 class="headline mt-5 mb-5">
        There are no Menu Items to display.</h1>
    <h2 class="subtitle-1 mt-5 mb-5">If there should be, try to reset</h2>
    <v-btn dark depressed color="black" class="mb-5" @click="initialize">Reload</v-btn>
    </template>


    
     </v-data-table>

        </v-card>




    </div>
</template>

<script>
export default {
    name: 'EditMenu',
    data() {
        return {

            loading: true,
            dialog: false,
            categories: ['Nigiri', 'Maki', 'Sashimi', 'Bowl', 'Vegetarian',
                'Dessert'
            ],
            headers: [{
                    text: 'Image',
                    value: 'imgUrl',

                    sortable: false,

                },
                { text: 'Id', value: 'id', align: 'start' },
                { text: 'Title', value: 'title', align: 'start' },

                { text: 'Category', value: 'category' },
                { text: 'Price', value: 'price' },
                { text: 'Popularity', value: 'timesOrdered' },
                { text: 'Added', value: 'dateAdded' },
                { text: 'Featured', value: 'isFeatured' },
                { text: 'Actions', value: 'actions', sortable: false },
            ],
            menuItems: [],
            editedIndex: -1,
            editedItem: {

                imgUrl: '',
                title: '',
                ingredients: '',
                allergens: '',
                category: '',
                isFeatured: false,
                price: Number(''),
                dateAdded: new Date().toDateString()
            },
            defaultItem: {

                imgUrl: 'default.jpg',
                title: '',
                ingredients: '',
                allergens: '',
                category: '',
                isFeatured: false,
                dateAdded: new Date().toDateString()
            },
            menuItem: []

        }
    },
    computed: {

        formTitle() {
            return this.editedIndex === -1 ? 'New  Menu Item' : 'Edit Menu Item'
        },
    },
    watch: {
        dialog(val) {
            val || this.close()
        },
    },

    created() {
        this.initialize()
        this.getDataFromApi()

    },
    methods: {
        getDataFromApi() {
            this.loading = true
            const webAPIUrl = "https://localhost:5001/menuitems/";

            this.$http.get(webAPIUrl)
                .then(response => {
                    setTimeout(
                        () => {
                            this.menuItems = response.data
                        },
                        3000
                    );

                    console.log(response.data);

                    setTimeout(() => {
                        this.loading = false
                    }, 3000)
                })

        },
        uploadImage(){
            let file = document.getElementById("file");
            let data = new FormData();
            
            data.append( "file", file.files[0] );
            console.log("WHAT IS THIS DATA?" + data.entries());

            if(file.value == "") { 
           
            console.log("No image uploaded :/ But default should")
            this.editedItem.imgUrl = "default.jpg";

            } else {

            console.log("THIS ITEM HAS AN IMAGE");
            
            this.$http({
                method: 'post',
                url: "https://localhost:5001/menuitems/savepicture",
                data: data,
                config: { headers: {'Content-Type': 'mulitpart/form-data'}}
            })

            this.editedItem.imgUrl = file.files[0].name;

            }

        },
        initialize() {
            this.menuItems = []
        },
        getColor(price) {
            if (price > 5) return 'green accent-3'
            else if (price > 3) return 'orange accent-3'
            else if (price < 1) return 'grey lighten-3 black--text'
            else return 'red accent-3'
        },
        setFeatured(isFeatured) {
            if(isFeatured != true ) {
                return 'grey lighten-3'
              
            
            } else {
                return 'green'
            }
        },
        editItem(item) {
            this.editedIndex = this.menuItems.indexOf(item)
            this.editedItem = Object.assign({}, item)
            this.dialog = true
            let webAPIUrl = `https://localhost:5001/menuitems/${this.editedIndex}`;
            console.log(this.editedIndex)
           
           this.$http.get(webAPIUrl)
                .then(result => {
                    this.menuItem = result.data;
                })
            this.getDataFromApi()
        },
        deleteItem(item) {
            const index = this.menuItems.indexOf(item)
            let webAPIUrl = `https://localhost:5001/menuitems/${item.id}`;
            this.menuItems.splice(index, 1)
            
            this.$http.delete(webAPIUrl)
                .then(
                    console.log("Deleted item with ID: " + item.id),
                )
        },
        close() {
            this.dialog = false
            setTimeout(() => {
                this.editedItem = Object.assign({}, this.defaultItem)
                this.editedIndex = -1
            }, 300)
        },
        save() {
            if (this.editedIndex > -1) {
                Object.assign(this.menuItems[this.editedIndex], this.editedItem)
                const webAPIUrl = "https://localhost:5001/menuitems/";
               
                this.$http.put(webAPIUrl, this.editedItem)
                    .then(response => {
                        console.log(response);
                        console.log("Put request firing ");
                    })

            } else {
                this.menuItems.push(this.editedItem)
                const webAPIUrl = "https://localhost:5001/menuitems";
                
                this.$http.post(webAPIUrl, this.editedItem)
                    .then(response => {
                        console.log(response);
                        console.log("Save post request firing ");
                        this.getDataFromApi()
                    })
                       
            }
       
            this.uploadImage()
            this.close()
        },
    },

}
</script>

<style scoped>
.full-w {
    width: 100%;
}

.shadow {
    -webkit-box-shadow: 0px 0px 50px 0px rgba(238, 238, 238, 9);
    -moz-box-shadow: 0px 0px 50px 0px rgba(238, 238, 238, 9);
    box-shadow: 0px 0px 50px 0px rgba(238, 238, 238, 9);
}

.dashboard-bg {
    background-color: #999999;
}

.round-img {
    border-radius: 50%;
}
</style>