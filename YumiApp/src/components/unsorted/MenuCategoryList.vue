<template>
<div>
<template v-if="loading">
    <AppLoader/>
</template>
<template v-else>
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
    </template>

</div> 
</template>
<script>
import AppLoader from '@/components/common/AppLoader.vue'
import MenuItem from '@/components/ui/MenuItem.vue'

export default {
    name: 'MenuCategoryList',
    components: {
        AppLoader,
        MenuItem
    },
    props: {
        displayItems: { type: Number, default: 3},
        searchTerm: {type: String, default: ""}
     
    },
    data() {
        return {
            loading: true,
            menuItems: [{}],
            menuItemSearch: [{}],
            category: this.$route.params.category
        }
    },





    methods: {
        getCategory(cat) {
            this.menuItems = [{}];
            const webAPIUrl = `https://localhost:5001/menuitems/category/${cat}`;
            this.$http.get(webAPIUrl)
                .then( response => {
                this.menuItems = response.data;
                this.loading = false;
                });
            },
    },
    created() {
        this.getCategory(this.category) 
    },
    beforeRouteUpdate (to, from, next) {
        this.getCategory(to.params.category);
        next();
    }
    
}
</script>