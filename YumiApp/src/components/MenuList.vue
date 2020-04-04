<template>
   
<div>
       
        <v-row>
            <v-col cols="12" v-if="!menuItems.length"><h2 clasS="display-1 grey--text">No Menu Items added</h2></v-col>
            <v-col cols="12" md="4" v-for="menuItem in menuItems.slice(0, displayItems) " :key="menuItem.id">
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
       
</div>
    
</template>
<script>

import MenuItem from './MenuItem.vue'
export default {
    name: 'MenuList',
    props: {
        displayItems: { type: Number, default: 3},
     
    },
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