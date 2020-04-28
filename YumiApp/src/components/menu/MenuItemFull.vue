<template>
    <div id="#top">

    <template v-if="loading">
        <AppLoader/>
    </template>
    <template v-else>

        <template v-if="Object.keys(menuItem).length === 0">
        <NothingToDisplay/>
        </template>
        <template v-else>

            <v-card flat>
                <v-row>

                    <v-col cols="12" md="12" class="d-flex">                  
                        <v-card-title class="display-2 font-weight-bold">{{menuItem.title}}</v-card-title>
                        
                        <MenuItemRating
                        :itemId="menuItem.id"/>
                    </v-col>

                    <v-col cols="12" md="8">
                        <v-img :src="`https://localhost:5001/images/${menuItem.imgSrc}`" height="350px">
                            <div class="overlay-gradient">
                                <template v-if="menuItem.isSpicy">
                                    <v-tooltip bottom>
                                        <template v-slot:activator="{ on }">
                                            <v-chip color="red" v-on="on" class="is-spicy mt-4 mr-4">
                                                <v-icon color="white">mdi-chili-hot</v-icon>
                                            </v-chip>
                                        </template>

                                        <span>This dish is spicy</span>

                                    </v-tooltip>
                                </template>

                                <div class="cat-chip">
                                    <v-card-text>
                                        <v-chip style="backgroundColor:rgba(255,255,255,0.4)" class="font-weight-bold white--text">{{menuItem.category}}</v-chip>
                                    </v-card-text>
                                </div>
                            
                            </div>
                        </v-img>

                        <v-card-title class="title font-weight-bold">Description:</v-card-title>
                        <v-card-text>
                        Lorem ipsum dolor sit, amet consectetur adipisicing elit. Quisquam, recusandae iste! Natus explicabo odit, ullam officiis libero amet nulla, ex illo facilis impedit mollitia reiciendis voluptatum ea perspiciatis sint? Quisquam recusandae esse iste nihil numquam quibusdam accusantium est accusamus repellat consectetur, nisi amet consequuntur dolorem, quas dolor iusto nesciunt quos.
                        </v-card-text>

                    </v-col>

                    <v-col cols="12" sm="12" md="4">

                        <MenuItemDetails
                        :itemId="menuItem.id"
                        :title="menuItem.title"
                        :ingredients="menuItem.ingredients"
                        :allergens="menuItem.allergens"
                        />

                    </v-col>
                </v-row>
            </v-card>

            <v-divider class="pa-5"></v-divider>
            <v-row>
                <v-col cols="12">
                    <h2>Similar Dishes</h2>
                </v-col>
            </v-row>

            <MenuList
            :items="menuItems.slice(0,4)"
            />
        </template>
    </template>

    </div>
</template>
<script>
import AppLoader from '@/components/common/AppLoader'
import MenuList from './MenuList'
import MenuItemDetails from './MenuItemDetails'
import MenuItemRating from '@/components/menu/MenuItemRating'
import NothingToDisplay from '@/components/common/NothingToDisplay'

export default {
    name: 'MenuItemFull',
    components: {
        AppLoader,
        NothingToDisplay,
        MenuList,
        MenuItemDetails,
        MenuItemRating

    },
    data(){
        return {
        loading: false,
        show: false,
        menuItem: {},
        cat: this.$route.params.category,
        menuItems: [{}]
        }
    },
    methods: {
        getItem(item) {
            this.loading = true
            const webAPIUrl = `https://localhost:5001/user/menuitems/${item}`;
            this.$http.get(webAPIUrl)
                .then( response => {
                    this.menuItem = response.data;
                    this.loading = false
                });

        },
          getSimilar(cat) {
            this.loading = true;
            const webAPIUrl = `https://localhost:5001/user/menuitems/category/${cat}`;
            this.$http.get(webAPIUrl)
                .then( response => {
                this.menuItems = response.data;
                this.loading = false;
                
            });

        },
        placeOrder() {
            let orders = [];
            orders = JSON.parse(localStorage.getItem("orders")) || [];
            orders.push(this.menuItem);
            localStorage.setItem("orders", JSON.stringify(orders));

        },
    },
    created() {
        this.getItem(this.$route.params.id)
        this.getSimilar(this.cat)
        console.log(this.$route.params.id)
        }

}
</script>

<style scoped>
.is-spicy {
    position: absolute;
    right: 0;
}
.cat-chip {
    position: absolute;
    bottom: 0;
    left: 0;
}
.overlay-gradient {
height: 350px;
background: -moz-linear-gradient(bottom, rgba(0,0,0,0.65) 0%, rgba(0,0,0,0) 100%); /* FF3.6-15 */
background: -webkit-linear-gradient(bottom, rgba(0,0,0,0.65) 0%,rgba(0,0,0,0) 100%); /* Chrome10-25,Safari5.1-6 */
background: linear-gradient(to top, rgba(0,0,0,0.65) 0%,rgba(0,0,0,0) 100%); /* W3C, IE10+, FF16+, Chrome26+, Opera12+, Safari7+ */
}
</style>