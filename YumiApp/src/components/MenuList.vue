<template>
    <div>
        <v-container>
        <v-row>
            <v-col cols="12" md="4" v-for="menuItem in menuItems" :key="menuItem.id">
        <MenuItem
      
        :title="menuItem.title"
        :image="menuItem.imgUrl"
        :category="menuItem.category"
        />
            </v-col>



        </v-row>
        <div class="text-center">
        <v-btn depressed rounded large color="amber accent-3" class="mt-5 mb-5">View our menu</v-btn>
        </div>
        </v-container>
        </div> 

</template>
<script>
import MenuItem from './MenuItem.vue'
export default {
    name: 'MenuList',
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