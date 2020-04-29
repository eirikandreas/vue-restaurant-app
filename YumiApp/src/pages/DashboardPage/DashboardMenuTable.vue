<template>
    <div>
        <v-toolbar flat color="transparent">
            <v-toolbar-title class="headline ml-n4">Edit menu</v-toolbar-title>           
            <v-spacer></v-spacer>
            <v-btn rounded depressed color="amber accent-3" @click.stop="dialog = true">Add item</v-btn>
        </v-toolbar>

  

                    <EditDialog
                    :active="dialog" 
                    :editedItemIndex="editedItemIndex"
                    :editedItem="editedItem"
                    @save-item="saveItem"
                    @new-item="newItem"
                    @close-dialog="closeDialog"
                    />

        <v-card class="mb-5">

                <template v-if="loading">
    
      <AppLoader/>

    </template>
    <template v-else>

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
                    @click="editItem(item)"
                    >
                    mdi-pencil
                    </v-icon>
                    <v-icon
                    small
                    @click.stop="deleteItem(item)"
                    >
                    mdi-delete
                    </v-icon>
                </template>

            </v-data-table>
                </template>
        </v-card>
        <!-- ALERT DIALOG -->
        <v-dialog v-model="delDialog" persistent max-width="490px">
            
            <v-card>
                <v-card-title class="red--text display-1"><v-icon color="red" class="mr-2 display-1">mdi-alert-circle-outline</v-icon>Alert!</v-card-title>
                <v-card-text>This will permanently delete this menu item with id "xxx" <br>Are you sure you want to delete it?</v-card-text>
                <v-card-actions>
                    <v-spacer></v-spacer>
                    <v-btn depressed rounded color="amber accent-3" @click="delDialog = false">Cancel</v-btn>
                    <v-btn depressed rounded color="grey lighten-2" @click="deleteItem(item)">Delete</v-btn>
                </v-card-actions>

            
            </v-card>

        </v-dialog>
        <!-- ALERT DIALOG END -->

    </div>
</template>

<script>
import AppLoader from '@/components/common/AppLoader'
import EditDialog from '@/components/dashboard/EditDialog'
export default {
    name: 'DashboardMenuTable',
    components: {
        AppLoader,
        EditDialog
    },
    data() {
        return {
            dialog: false,
            delDialog: false,
            loading: true,
            headers: [
                { text: 'Id', align: 'start', value: 'id'},
                { text: 'Image', value: 'imgSrc' },
                { text: 'Title', value: 'title' },
                { text: 'Category', value: 'category' },
                { text: 'Price', value: 'price' },
                { text: 'Ordered', value: 'timesOrdered' },
                { text: 'Actions', value: 'actions', sortable: false }
            ],
            menuItems: [],
            editedItemIndex: -1,
            editedItem: {
               
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
        //Henter retter fra API
        getData() {
            this.editedItem = Object.assign({}, this.defaultMenuItem)
            this.loading = true
            const webAPIUrl = "https://localhost:5001/admin/menuitems";

            this.$http.get(webAPIUrl)
                .then(response => {
                    this.menuItems = response.data,
                    this.loading = false
                })
        },
        /*
        Setter en Index verdi på det valgte objektet for midlertidig lagring,
        for så tilegne det innsendte objektet til editedItem objektet
        */
        editItem (item) {
            this.editedItemIndex = this.menuItems.indexOf(item)
            this.editedItem = Object.assign({}, item)
            this.dialog = true
        },
        /*
        Sletter objektet fra menuItems arrayet samt sletter det samme objektet
        i APIet.
        */
        deleteItem(item) {
            const index = this.menuItems.indexOf(item)
            this.menuItems.splice(index, 1)
            let webAPIUrl = `https://localhost:5001/admin/menuitems/${item.id}`;
            this.$http.delete(webAPIUrl)
        },
        /*
        
        Benytter $set for å kunne dynamisk endre properties til String
        for at APIet skal kunne motta informasjonen.

        Ref: https://vuejs.org/v2/guide/reactivity.html
        */ 
        newItem() {
            let priceInt = parseInt(this.editedItem.price);
            this.$set(this.editedItem, 'price', priceInt);
            

            let descriptionString = this.editedItem.description.toString();
            this.$set(this.editedItem, 'description', descriptionString);

            let ingredientsString = this.editedItem.ingredients.toString();
            this.$set(this.editedItem, 'ingredients', ingredientsString);


            let allergensString = this.editedItem.allergens.toString();
            this.$set(this.editedItem, 'allergens', allergensString);

            let categoryString = this.editedItem.category.toString();
            this.$set(this.editedItem, 'category', categoryString);
            //Legger til ny rett i APIet
            const webAPIUrl = "https://localhost:5001/admin/menuitems";
            this.$http.post(webAPIUrl, this.editedItem)
            .then(response => {
                console.log(response);
                console.log("Save post request firing ");
                this.getData()
                this.dialog = false;
                })
        },
        saveItem() {
            let priceInt = parseInt(this.editedItem.price);
            this.$set(this.editedItem, 'price', priceInt);
            

            let descriptionString = this.editedItem.description.toString();
            this.$set(this.editedItem, 'description', descriptionString);

            let ingredientsString = this.editedItem.ingredients.toString();
            this.$set(this.editedItem, 'ingredients', ingredientsString);


            let allergensString = this.editedItem.allergens.toString();
            this.$set(this.editedItem, 'allergens', allergensString);

            let categoryString = this.editedItem.category.toString();
            this.$set(this.editedItem, 'category', categoryString);
            //Setter redigert rett i APIet
            const webAPIUrl = "https://localhost:5001/admin/menuitems/";
            this.$http.put(webAPIUrl, this.editedItem)
                .then(response => {
                    console.log(response),
                    this.getData()
                    this.dialog = false;
                })

        },
        //Setter editedItem og editedIndex tilbake til angitte verdier
        closeDialog() {
            this.dialog = false
            this.editedItem = Object.assign({}, this.defaultItem)
            this.editedIndex = -1
            }
    },
    created() {
        this.editedItem = Object.assign({}, this.defaultMenuItem)
        this.getData()
    }
}
</script>
<style scoped>
.round-img {
    border-radius: 50%;
}
</style>