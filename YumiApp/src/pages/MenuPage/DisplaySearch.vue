<template>
    <div>
        <template v-if="loading">
            <AppLoader/>
        </template>
        <template v-else>
            <template v-if="menuItems.length === 0 || empty == true">
                <v-row>
                    <v-col>
                        <v-card flat min-height="300px" class="d-flex align-center justify-center">
                            <h1 class="display-2 grey--text"> No Menu Items with the name "{{query}}"</h1>
                        </v-card>
                    </v-col>
                </v-row>
            </template>

            <template v-else>
                <MenuList
                :items="menuItems"
                />
            </template>

        </template>

    </div>
</template>
<script>
import AppLoader from '@/components/common/AppLoader'
import MenuList from '@/components/menu/MenuList'

export default {
    name: 'DisplaySearch',
    props: ["query"],
    components: {
        AppLoader,
        MenuList
    },
    data() {
        return {
            loading: false,
            empty: false,
            menuItems: [{}]

        }
    },
     watch: {
    "$route.query.q":{
            immediate: true,
            handler(query){
                this.searchByTitle(query) 
            }
        }
     },
    methods: {
        searchByTitle(title){
            this.loading = true;

            if(title == "") {
                this.empty = true;
                this.loading = false;

            } else {
                const webAPIUrl = `https://localhost:5001/menuitems/title/${title}`;
                this.$http.get(webAPIUrl)
                .then( response => {
                this.menuItems = response.data;
                this.loading = false;
                });
            }
         
        },
    }
}
</script>