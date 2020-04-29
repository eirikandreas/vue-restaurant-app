<template>
<div>

    <template v-if="menuItems.length === 0">
      <NothingToDisplay/>
    </template>

    <template v-else>
        <v-row>
            <v-col cols="12" md="6" lg="3" v-for="menuItem in filterByRated()" :key="menuItem.id">

                <MenuItem
                :id="menuItem.id"
                :title="menuItem.title"
                :image="menuItem.imgSrc"
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
import MenuItem from '@/components/menu/MenuItem'
import NothingToDisplay from '@/components/common/NothingToDisplay'

export default {
    name: 'FilteredMenuList',
    components: {
        MenuItem,
        NothingToDisplay
    },
    data() {
        return {
            menuItems: [{}],
        }
    },
    methods: {
        /*
        Filtrerer menuItems arrayet basert på rating, begrenser det og reverserer 
        slik at høyest verdi vises først
        */
        filterByRated() {
            return this.menuItems.filter( menuItem => menuItem.rating > 3).reverse().splice(0, 4)
        },
        //Initialiserer menuItems og henter data fra databasen 
        getAll() {
            this.menuItems = [{}];
            const webAPIUrl = "https://localhost:5001/user/menuitems/";
            this.$http.get(webAPIUrl)
                .then( response => {
                    this.menuItems = response.data;
                });
        },
    },
    created() {
        this.getAll()  
    },
}
</script>