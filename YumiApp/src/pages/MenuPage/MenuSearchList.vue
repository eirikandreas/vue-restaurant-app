<template>
<div>
    <template v-if="menuItems.length === 0">
        <v-row>
            <v-col>
                <v-card flat min-height="300px" class="d-flex align-center justify-center">

                    <template v-if="searchTerm == ''">
                        <h1 class="display-2 grey--text"> No Menu Items to display</h1>
                    </template>

                    <template v-else>
                        <h1 class="display-2 grey--text text-center"> No Menu Items with the name "{{searchTerm}}"</h1>
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
    props: {
        displayItems: { type: Number, default: 3},
        searchTerm: {type: String, default: ""}
    },
    components: {
        MenuItem
    },
    data() {
        return {
            menuItems: [{}],
            menuItemSearch: [{}],
            title: this.$route.params.title
        }
    },
    methods: {
        getCategory(cat) {
            this.menuItems = [{}];
            const webAPIUrl1 = `https://localhost:5001/menuitems/title/${cat}`;
            console.log("DETTE ER URL" + webAPIUrl1)
            this.$http.get(webAPIUrl1)
                .then( response => {
                    this.menuItems = response.data;
                });
        },
    },
    created() {
        console.log('The id is: ' + this.$route.params.title);
        this.getCategory(this.title)        
    },
    beforeRouteUpdate (to, from, next) {
        this.getCategory(to.params.title);
        next();
    }
   
}
</script>