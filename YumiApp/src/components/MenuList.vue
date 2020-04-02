<template>
   
<div>
       
        <v-row>
            <v-col cols="12" v-if="!menuItems.length"><h2 clasS="display-1 grey--text">No Menu Items added</h2></v-col>
            <v-col cols="12" md="4" v-for="menuItem in menuItems.slice(0, 3) " :key="menuItem.id">
        <MenuItem
        :id="menuItem.id"
        :title="menuItem.title"
        :image="menuItem.imgUrl"
        :category="menuItem.category"
        :price="menuItem.price"
        :rating="menuItem.rating"
        />
            </v-col>



        </v-row>
        <div class="text-center">
        <v-btn depressed rounded large color="amber accent-3" class="mt-5 mb-5">View our menu</v-btn>
        </div>
</div>
    
</template>
<script>
import MenuItem from './MenuItem.vue'
export default {
    name: 'MenuList',
    components: {
        MenuItem
    },
    data() {
        return {
           menuItems: [{ title: ""          }]
        }
    
    },
    created(){
        
        let webAPIUrl = "https://localhost:5001/menuitems";
        this.$http.get( webAPIUrl )
            .then( result => {
                console.log( result.data );
                this.menuItems = result.data;
            } )



            
        }
    
}
</script>