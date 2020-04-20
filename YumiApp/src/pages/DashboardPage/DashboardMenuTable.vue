<template>
    <div>
        <v-toolbar flat color="transparent">
            <v-toolbar-title class="headline ml-n4">Edit menu</v-toolbar-title>           
            <v-spacer></v-spacer>
            <v-btn rounded depressed color="amber accent-3" @click.stop="createMenuItem">Add item</v-btn>
        </v-toolbar>

        <!-- DIALOG -->
        <v-dialog :fullscreen="$vuetify.breakpoint.xsOnly" v-model="dialog" persistent>
            <v-card>
                <v-form ref="form" v-model="valid" lazy-validation>
                    <v-container>
                        <v-card-title class="headline">Add menu item</v-card-title>
                        <v-row>
                            <v-col cols="12" md="12">
                                <v-text-field outlined label="Title" v-model="newMenuItem.title" :rules="reqRule"></v-text-field>
                            </v-col>

                            <v-col cols="12" sm="6" md="8">
                                <v-textarea outlined height="105" class="description" label="Description"></v-textarea>
                                <v-textarea outlined height="105" class="ingredients" label="Ingredients" :rules="reqRule"></v-textarea>
                            </v-col>

                            <v-col cols="12" sm="6" md="4">
                                <v-select v-model="newMenuItem.category" :items="categories" class="categories" label="Select category" outlined :rules="reqRule"></v-select>

                                <!-- 
                                    Select som legger valgene til bruker til et Array. Dette gjøres så om til en String.
                                    Dette er gjort for å øke brukeropplevelsen når brukeren legger til allergener.
                                -->
                                <v-select
                                v-model="newMenuItem.allergens"
                                :items="allergens"
                                class="allergens"
                                outlined
                                chips
                                label="Pick allergens"
                                multiple
                                :rules="reqRule"
                                ></v-select>

                                <v-text-field color="amber accent-3" dense outlined v-model="newMenuItem.price" type="number" label="Price" :rules="reqRule"></v-text-field>
                            </v-col>
    
                            <v-col cols="12" md="12">
                                <v-file-input 
                                id="file" 
                                name="file" 
                                accept="image/*" 
                                outlined label="File input" 
                                placeholder="Upload your documents" 
                                prepend-icon="mdi-camera" 
                                counter 
                                :show-size="1000"
                                ></v-file-input>
                            </v-col>
                
                            <v-col cols="12" md="12">
                                <v-card flat outlined>
                                    <v-card-text>
                                        <v-switch v-model="newMenuItem.isSpicy" inset :label="`Add spicy notification`"></v-switch>
                                        <v-switch v-model="newMenuItem.isFeatured" inset :label="`Set featured on frontpage`"></v-switch>
                                    </v-card-text>
                                </v-card>
                            </v-col>
                        </v-row>
 
                        <v-card-actions>
                            <v-spacer></v-spacer>
                            <v-btn rounded depressed color="amber accent-3" @click="closeDialog">Cancel</v-btn>
                            <template v-if="newItem">
                                <v-btn :disabled="!valid" rounded depressed color="amber accent-3" @click="validate()">Create Item</v-btn>
                            </template>

                            <template v-if="editItem">
                            <v-btn :disabled="!valid" rounded depressed color="amber accent-3" @click="validate()">Edit Item</v-btn>
                            </template>
                        </v-card-actions>
          
                    </v-container>
                </v-form>
            </v-card>
        </v-dialog>
        <!--- END DIALOG -->


        <v-card class="mb-5">
            <v-data-table
            :headers="headers"
            :items="menuItems"
            item-key="this.menuItems.id"
            sort-by="id"
            sort-desc
            >
                <template v-slot:item.imgSrc="{ item }">
                    <v-img class="round-img" :src="`https://localhost:5001/images/${item.imgSrc}`" width="40px" height="40px"></v-img>
                </template>
                
                <template v-slot:item.actions="{ item }">
                    <v-icon
                    small
                    class="mr-2"
                    @click="editMenuItem(item.id)"
                    >
                    mdi-pencil
                    </v-icon>
                    <v-icon
                    small
                    @click.stop="openDelDialog(item.id)"
                    >
                    mdi-delete
                    </v-icon>
                </template>

            </v-data-table>
        </v-card>
        <!-- ALERT DIALOG -->
        <v-dialog v-model="delDialog" persistent max-width="490px">
            
            <v-card>
                <v-card-title class="red--text display-1"><v-icon color="red" class="mr-2 display-1">mdi-alert-circle-outline</v-icon>Alert!</v-card-title>
                <v-card-text>This will permanently delete this menu item with id "{{delId}}" <br>Are you sure you want to delete it?</v-card-text>
                <v-card-actions>
                    <v-spacer></v-spacer>
                    <v-btn depressed rounded color="amber accent-3" @click="delDialog = false">Cancel</v-btn>
                    <v-btn depressed rounded color="grey lighten-2" @click="deleteMenuItem(delId)">Delete</v-btn>
                </v-card-actions>
            </v-card>

        </v-dialog>
        <!-- ALERT DIALOG END -->

    </div>
</template>

<script>
export default {
    name: 'DashboardMenuTable',
    data() {
        return {
            delDialog: false,
            delId: null,
            newItem: false,
            editItem: false,
            valid: true,
             reqRule: [
                v => !!v || 'This field is required'
            ],
            isSpicy: false,
            isFeatured: false,
            dialog: false,
            loading: true,
            categories: this.$categories.getName().slice(1, 7),
            allergens: this.$allergens.getAll(),
            headers: [
                { text: 'Id', align: 'start', value: 'id'},
                { text: 'Image', value: 'imgSrc' },
                { text: 'Title', value: 'title' },
                { text: 'Category', value: 'category' },
                { text: 'Price', value: 'price' },
                { text: 'Ordered', value: 'timesOrdered' },
                { text: 'Actions', value: 'actions', sortable: false }
            ],
            defaultPrice: 0,
            menuItems: [{
                imgSrc: 'default.jpg'
            }],
            newMenuItem: {
                title: '',
                ingredients: '',
                allergens: '',
                category: '',
                imgSrc: 'default.jpg',
                price: Number(''),
                rating: 0,
                isSpicy: false,
                isFeatured: false,
                dateAdded: new Date().toDateString()
            },
            defaultMenuItem: {
                title: '',
                ingredients: '',
                allergens: '',
                category: '',
                imgSrc: 'default.jpg',
                rating: 0,
                isSpicy: false,
                isFeatured: false,
                dateAdded: new Date().toDateString()
            },
            
            
        }
    },
    
    methods: {
            validate () {
                if(this.$refs.form.validate() == true) {
                    if(this.newItem == true) {
                         this.postMenuItem();
                    } else {
                        console.log("Will put this ID " + this.newMenuItem.id)
                        this.putMenuItem();
                    }
                   
        
                } else {
                    this.$refs.form.validate()
                }
            },

            reset() {
                this.$refs.form.reset()
            },

            getMenuItems() {
                this.loading = true
                const webAPIUrl = "https://localhost:5001/admin/";

                this.$http.get(webAPIUrl)
                    .then(response => {
                        this.menuItems = response.data;

                    });
            },

            initMenuItems() {
                return this.newMenuItem = this.defaultMenuItem;
            },

            postMenuItem() {
         

                /*
                    Benytter $set for å kunne dynamisk endre propertien fra Array til String
                    for at APIet skal kunne motta informasjonen.

                    Ref: https://vuejs.org/v2/guide/reactivity.html
    
                */ 
               let priceInt = parseInt(this.newMenuItem.price);
               this.$set(this.newMenuItem, 'price', priceInt)

                let allergensString = this.newMenuItem.allergens.toString();
                this.$set(this.newMenuItem, 'allergens', allergensString);

                let categoryString = this.newMenuItem.category.toString();
                this.$set(this.newMenuItem, 'category', categoryString);
 
                this.uploadImage();
                this.menuItems.push(this.newMenuItem);

                const webAPIUrl = "https://localhost:5001/admin";
                this.$http.post(webAPIUrl, this.newMenuItem)
                    .then(
                        this.closeDialog(),
                        console.log("POST request firing "),
                        this.getMenuItems(),
                    );
            },

            createMenuItem() {
                this.newItem = true;
                this.dialog = true;

                /*  
                    Når newMenuItem-objektet har fått definert properties kan ikke Vue dynamisk 
                    endre disse. For å unngå at brukeren får allerede lagrede verdier benyttes 
                    Object.assign for lage newMenuItem på nytt og fylle verdiene fra defaultMenuItem 
                    inn i newMenuItem-objektet.

                    Ref: https://vuejs.org/v2/guide/reactivity.html
                */
                this.newMenuItem = Object.assign({}, this.defaultMenuItem)

            },

            editMenuItem(id) {
                this.editItem = true;
                this.dialog = true;
                console.log(id)
                let webAPIUrl = `https://localhost:5001/admin/${id}`;
                this.$http.get(webAPIUrl)
                    .then(response => {
                        this.newMenuItem = response.data;
                        console.log(this.newMenuItem)

                    });
                
                console.log(webAPIUrl)
      

            },

            putMenuItem() {
                let priceInt = parseInt(this.newMenuItem.price);
                this.$set(this.newMenuItem, 'price', priceInt)

                let allergensString = this.newMenuItem.allergens.toString();
                this.$set(this.newMenuItem, 'allergens', allergensString);

                let categoryString = this.newMenuItem.category.toString();
                this.$set(this.newMenuItem, 'category', categoryString);
 
                this.uploadImage();
                this.menuItems.push(this.newMenuItem);

                const webAPIUrl = "https://localhost:5001/menuitems/";
                this.$http.put(webAPIUrl, this.newMenuItem)
                    .then(response => {
                        console.log(response);
                        console.log("Put request firing ");
                        this.closeDialog();
                    })
                
            },

            deleteMenuItem(id) {
                let webAPIUrl = `https://localhost:5001/admin/${id}`;
                this.$http.delete(webAPIUrl)
                    .then(
                        console.log("Deleted item with ID: " + id),
                    )

            },

            deleteDialog(id) { 
                
                
                console.log(id)

            },

            openDelDialog(id) {
                this.delDialog = true;
                this.delId = id;
                console.log(id)

            },
            uploadImage(){
                let file = document.getElementById("file");
                let data = new FormData();
                
                data.append( "file", file.files[0] );
                console.log("WHAT IS THIS DATA?" + data.entries());

                if(file.value == "") { 
                    console.log("No image uploaded :/ But default should")
                    this.newMenuItem.imgSrc = "default.jpg";
                } else {
                    console.log("THIS ITEM HAS AN IMAGE");
                    this.$http({
                        method: 'post',
                        url: "https://localhost:5001/admin/savepicture",
                        data: data,
                        config: { headers: {'Content-Type': 'mulitpart/form-data'}}
                    });

                    this.newMenuItem.imgSrc = file.files[0].name;

                }
            },
            closeDialog() {
                this.dialog = false;
                this.newItem = false;
                this.editItem = false;

                this.newMenuItem = Object.assign({}, this.defaultMenuItem)
            }



        },

    created() {
        this.initMenuItems()
        this.getMenuItems()
    }

}
</script>
<style scoped>
.round-img {
    border-radius: 50%;
}
</style>