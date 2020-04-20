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
                <v-col cols="12" sm="6" md="4" lg="3" v-for="menuItem in menuItems" :key="menuItem.id">

                    <MenuItem
                    :id="menuItem.id"
                    :title="menuItem.title"
                    :image="menuItem.imgUrl"
                    :category="menuItem.category"
                    :price="menuItem.price"
                    :rating="menuItem.rating"
                    :isSpicy="menuItem.isSpicy"
                    />

                </v-col>
            </v-row>
        </template>

    </template>
       
</div>
</template>
<script>
import AppLoader from '@/components/common/AppLoader'
import MenuItem from '@/components/menu/MenuItem'
export default {
    name: 'MenuList',
    props: ["query"],
    components: {
        AppLoader,
        MenuItem
    },
    data() {
        return {
            limit: true,
            loading: false,
            menuItems: [{}],
            menuItemSearch: [{}],
            category: this.$route.params.category
        }
    },
    watch: {
    "$route.query.q":{
            immediate: true,
            handler(query){
                console.log("Something" + query);
                this.searchByTitle(query) 
            }
        },
    "$route.params.category":{
            immediate: true,
            handler(category){
                if(category == "all") {
                    this.getAll()
                    console.log("PROMP")

                } else {
                console.log("CATEGORY" + category);
                this.getCategory(category)
                }
            }
        }

    },
    methods: {
        getAll() {
            this.loading = true;
            this.menuItems = [{}];
            const webAPIUrl = "https://localhost:5001/menuitems/";
            this.$http.get(webAPIUrl)
                .then( response => {
                    this.menuItems = response.data;
                    this.loading = false;
                });
        },

        searchByTitle(title){
            this.loading = true;
            const webAPIUrl = `https://localhost:5001/menuitems/title/${title}`;
            this.$http.get(webAPIUrl)
                .then( response => {
                this.menuItems = response.data;
                this.loading = false;
                });
        },

        getCategory(cat) {
            this.loading = true;
            this.menuItems = [{}];
            const webAPIUrl = `https://localhost:5001/menuitems/category/${cat}`;
            this.$http.get(webAPIUrl)
                .then( response => {
                this.menuItems = response.data;
                this.loading = false;
                });
        },

        filterItems(){
           return this.menuItems.filter( menuItem => menuItem.rating > 3).reverse()

        }
    },
    mounted() {
         this.getAll()
         this.getCategory()
         


    },
    created() {
        
        this.getAll()
     

     
    },

}
</script>