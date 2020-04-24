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
                <v-col cols="12" sm="6" md="4" lg="3" v-for="menuItem in items" :key="menuItem.id">

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

  
       
</div>
</template>
<script>
import MenuItem from '@/components/menu/MenuItem'
export default {
    name: 'MenuList',
    props: {
        items: {type: Array}
    },
    components: {
        MenuItem
    },
    data() {
        return {
            menuItems: [{}],
        }
    },
}
</script>