<template>
<div>

    <template v-if="menuItems.length === 0">
        <v-row>
            <v-col>
                <v-card flat min-height="300px" class="d-flex align-center justify-center">
                    <h1 class="display-2 grey--text"> No Menu Items to display</h1>
                </v-card>
            </v-col>
        </v-row>
    </template>

   <template v-else>
        <v-row>
            <v-col cols="12" sm="6" md="4" lg="3" v-for="menuItem in filterByRated()" :key="menuItem.id">

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
    name: 'MenuList',
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
            category: this.$route.params.category
        }
    },
    methods: {
        filterByRated() {

        return this.menuItems.filter( menuItem => menuItem.rating > 3).reverse()
       
        },
        getAll() {
            this.menuItems = [{}];
            const webAPIUrl = "https://localhost:5001/menuitems/";
            this.$http.get(webAPIUrl)
                .then( response => {
                    this.menuItems = response.data;
                });
        },
    },
    created() {
        this.getAll()  
    },
    beforeRouteUpdate (to, from, next) {
        this.getCategory(to.params.category);
        next();
    }

}
</script>