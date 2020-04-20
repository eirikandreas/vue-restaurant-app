<template>
<div>
    <template v-if="menuItems.length === 0">
        <v-row>
            <v-col>
                <v-card flat min-height="300px" class="d-flex align-center justify-center">

                   

                    <template v-if="query == ''">
                         
                        <h1 class="display-2 grey--text"> No Menu Items to display</h1>
                    </template>

                    <template v-else>
                        <h1 class="display-2 grey--text text-center"> No Menu Items with the name "{{query}}"</h1>
                    </template>

                </v-card>
            </v-col>
        </v-row>
   </template>

   <template v-else>
        <v-row>
            <v-col cols="12" sm="6" md="4" lg="3" v-for="menuItem in menuItems " :key="menuItem.id">
           
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
    </template>
       
</div>
</template>
<script>

import MenuItem from '@/components/MenuItem.vue'
export default {
    name: 'MenuSearchList',
    props: ["query"],
    components: {
        MenuItem
    },
    data() {
        return {
            menuItems: [{}],
            menuItemSearch: [{}],
            searchWord: this.query,
  
           
        }
    },

        watch: {
        "$route.query.q":{
            immediate: true,
            handler(query){

                console.log("Something" + query);
                this.searchByTitle(query)
                
            }
        }

    },



    methods: {
        searchByTitle(title){
        const webAPIUrl = `https://localhost:5001/menuitems/title/${title}`;

      this.$http.get(webAPIUrl)
        .then( response => {
          this.menuItems = response.data;
        });

    }
    },
    created() {
        this.searchByTitle(this.searchWord)   
        console.log("MENUSEARCHLIST" + this.searchWord)     
    },
    beforeRouteUpdate (to, from, next) {
        this.searchByTitle(this.searchWord);
        next();
    }
   
}
</script>