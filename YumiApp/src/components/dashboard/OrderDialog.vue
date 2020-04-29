<template>
    <v-dialog persistent :value="active" v-model="active" max-width="600px">
        <v-card class="mx-auto">

            <v-sheet tile color="grey lighten-3">
                <v-row>
                    <v-col cols="12" sm="12" class="pt-0 pb-0 d-flex">
                        <v-card-title>Order ID: 1</v-card-title>
                        <v-spacer></v-spacer>
                        <v-card-title>Order Date: 25 April</v-card-title>
                    </v-col>
                </v-row>
            </v-sheet>

            <v-divider></v-divider>

            <v-row>
                <v-col cols="12" sm="12">
                    <v-list>
                        <v-list-item>
                            <v-list-item-content>
                                <v-list-item-title class="title">Name:</v-list-item-title>
                            </v-list-item-content>

                            <v-list-item-content>
                                <v-list-item-title class="d-flex justify-end">{{order.name}}</v-list-item-title>
                            </v-list-item-content>
                        </v-list-item>

                        <v-list-item>
                            <v-list-item-content>
                                <v-list-item-title class="title">Email: </v-list-item-title>
                            </v-list-item-content>

                            <v-list-item-content>
                                <v-list-item-title class="d-flex justify-end">{{order.email}}</v-list-item-title>
                            </v-list-item-content>
                        </v-list-item>

                        <v-list-item>
                            <v-list-item-content>
                                <v-list-item-title class="title">Phonenumber: </v-list-item-title>
                            </v-list-item-content>

                            <v-list-item-content>
                                <v-list-item-title class="d-flex justify-end">{{order.phoneNumber}}</v-list-item-title>
                            </v-list-item-content>
                        </v-list-item>

                        <v-list-item>
                            <v-list-item-content>
                                <v-list-item-title class="title">Address: </v-list-item-title>
                            </v-list-item-content>

                            <v-list-item-content>
                                <v-list-item-title class="d-flex justify-end">{{order.address}}</v-list-item-title>
                            </v-list-item-content>
                        </v-list-item>
                    </v-list>
                </v-col>
            </v-row>

            <v-divider></v-divider>

            <v-row>
                <v-col cols="12" sm="12">
                    <v-card-title>Order:</v-card-title>
                        <v-list v-for="(item, index) in orderItems" :key="index">
                            <v-list-item>
                                <v-list-item-avatar>
                                    <v-img :src="`https://localhost:5001/images/${item.imgSrc}`"></v-img>
                                </v-list-item-avatar>

                                <v-list-item-content>
                                    <v-list-item-title v-text="item.title"></v-list-item-title>
                                </v-list-item-content>

                                <v-list-item-content>
                                    <v-list-item-title class="d-flex justify-end">Quantity: {{item.quantity}}</v-list-item-title>
                                </v-list-item-content>
                            </v-list-item>
                            <v-divider></v-divider>
                        </v-list>
                    </v-col>
            </v-row>

            <v-row>
                <v-col cols="12" sm="12">
                    <v-card-title>Comment:</v-card-title>
                    <v-card-text>{{order.comment}}</v-card-text>
                </v-col>
            </v-row>

            <v-divider></v-divider>

            <v-card-actions>
                <v-spacer></v-spacer>
                    <v-btn rounded depressed color="amber accent-3" @click="close">Cancel</v-btn>
                    <v-btn rounded depressed color="amber accent-3" @click="deleteItem(order)">Finished</v-btn>
                </v-card-actions>
        </v-card>
    </v-dialog>
</template>
<script>
export default {
    name: 'OrderDialog',
    props: {
        active: {type: Boolean},
        order: {type: Object},
        orderItems: {type: Array},
        closeDialog: {type: Object},
        deleteOrder: {type: Object}
    },
    methods: {
        //$emit tillater bruk av funksjoner fra parent-component i child-component.
        close() {
            this.$emit('close-dialog')
        },
        deleteItem(item) {
            this.$emit('delete-order', item)
        }
    }
}
</script>