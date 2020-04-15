<template>

<!-- MAY BE REDUNDANT -->
   
<div>
       
        <v-text-field dense rounded outlined label="Search menu" v-model="searchTerm"></v-text-field>
         <input @click="searchByTitle" type="button" value="Search">
        <v-row>
            
            <v-col cols="12" v-if="!menuItems.length"><h2 clasS="display-1 grey--text">No Menu Items added</h2></v-col>
            
            
            
            
            
            
            
                        <v-col cols="12" md="4" v-for="menuItemSearch in menuItemSearch" :key="menuItemSearch.id">



 


        <MenuItem
        :id="menuItemSearch.id"
        :title="menuItemSearch.title"
        :image="menuItemSearch.imgUrl"
        :category="menuItemSearch.category"
        :price="menuItemSearch.price"
        :rating="menuItemSearch.rating"
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
           menuItems: [{ title: ""          }],
           menuItemSearch: [{}],
           searchTerm: "Not set",
           searchWord: this.$route.params.query,
    
        }
    
    },
    methods: {
        searchByTitle(title){
        const webAPIUrl = `https://localhost:5001/menuitems/title/${title}`;

      this.$http.get(webAPIUrl)
        .then( response => {
          this.menuItemSearch = response.data;
        });

    },

    },
    created(){
        
    this.searchByTitle(query) 



            
   
    }
    
}
</script>