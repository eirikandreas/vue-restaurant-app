<template>
    <v-card class="shadow" flat>
        <v-list two-line>
            <v-list-item>
                <v-list-item-content>
                    <v-list-item-title class="title">{{title}}</v-list-item-title>
                </v-list-item-content>
            </v-list-item>

            <v-divider inset></v-divider>

            <v-list-item>
                <v-list-item-icon>
                    <v-icon color="grey lighten-1">mdi-nutrition</v-icon>
                </v-list-item-icon>

                <v-list-item-content>
                    <v-list-item-title>Ingredients</v-list-item-title>
                    <v-list-item-subtitle>{{ingredients}}</v-list-item-subtitle>
                </v-list-item-content>
            </v-list-item>

            <v-divider inset></v-divider>

            <v-list-item>
                <v-list-item-icon>
                    <v-icon color="grey lighten-1">mdi-egg-outline</v-icon>
                </v-list-item-icon>

                <v-list-item-content>
                    <v-list-item-title>Allergens</v-list-item-title>
                    <v-list-item-subtitle>{{allergens}}</v-list-item-subtitle>
                </v-list-item-content>
            </v-list-item>

            <v-divider inset></v-divider>

            <v-list-item>

                <v-list-item-action></v-list-item-action>

                <v-list-item-content>
                <v-list-item-title class="d-flex justify-end headline font-weight-bold">{{price}}</v-list-item-title>
                </v-list-item-content>
            </v-list-item>

            <div class="pl-3 pr-3 pt-5 pb-5">
                <OrderButton :id="itemId"/>
            </div>
        </v-list>
    </v-card>
</template>
<script>
import OrderButton from '@/components/ui/OrderButton'
export default {
    name: 'MenuDet',
    props: {
        itemId: { type: Number, default: 0},
        title: { type: String, default: "Not Set"},
        ingredients: { type: String, default: "Not Set"},
        allergens: { type: String, default: "Not Set"},
        price: {type: Number, default: 0}
    },
    components: {
        OrderButton
    }
}
</script>
<style scoped>
.shadow {
    -webkit-box-shadow: 0px 0px 25px 0px rgba(238, 238, 238, 9);
    -moz-box-shadow: 0px 0px 25px 0px rgba(238, 238, 238, 9);
    box-shadow: 0px 0px 25px 0px rgba(238, 238, 238, 9);
}
</style>