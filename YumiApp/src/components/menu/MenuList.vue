<template>
<div>
    <template v-if="menuItems.length === 0">
        <NothingToDisplay/>
    </template>

    <template v-else>
        <v-row>
            <v-col cols="12" sm="6" md="4" lg="3" v-for="menuItem in items" :key="menuItem.id">

                <MenuItem
                :id="menuItem.id"
                :title="menuItem.title"
                :image="menuItem.imgSrc"
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
import NothingToDisplay from '@/components/common/NothingToDisplay'

export default {
    name: 'MenuList',
    props: {
        items: {type: Array, required: true}
    },
    components: {
        MenuItem,
        NothingToDisplay
    },
    data() {
        return {
            menuItems: [{}],
        }
    },
}
</script>