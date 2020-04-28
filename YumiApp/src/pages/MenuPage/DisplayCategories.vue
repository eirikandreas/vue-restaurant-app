<template>
    <div>
        <template v-if="loading">
            <AppLoader/>
        </template>
        <template v-else>

            <template v-if="menuItems.length === 0">
               <NothingToDisplay
               text="No Menu Items"/>
            </template>

            <MenuList
            :items="menuItems"
            />
        </template>

    </div>
</template>
<script>
import AppLoader from '@/components/common/AppLoader'
import NothingToDisplay from '@/components/common/NothingToDisplay'
import MenuList from '@/components/menu/MenuList'
export default {
    name: 'DisplayCategories',
    components: {
        AppLoader,
        NothingToDisplay,
        MenuList
    },
    data() {
        return {
            loading: false,
            cat: this.$route.params.category,
            menuItems: [{}]
        }
    },
    watch: {
        "$route.params.category":{
            immediate: true,
            handler(category){
                if(category == "all") {
                    this.getAll()

                } else {
                    this.getCategory(category)
                }
            }
        }
    },
    methods: {
        getAll(){
            this.loading = true;
            let webAPIUrl = "https://localhost:5001/user/menuitems";
            this.$http.get( webAPIUrl )
                .then( result => {
                    this.menuItems = result.data;
                    this.loading = false;
                })            
        },
        getCategory(cat) {
            this.loading = true;
            this.menuItems = [{}];
            const webAPIUrl = `https://localhost:5001/user/menuitems/category/${cat}`;
            this.$http.get(webAPIUrl)
                .then( response => {
                    this.menuItems = response.data;
                    this.loading = false; 
                })
        }
    }
}
</script>