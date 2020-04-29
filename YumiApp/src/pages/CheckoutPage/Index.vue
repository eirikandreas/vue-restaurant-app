<template>
    <v-container>
        <template v-if="!orders">
            <NothingToDisplay
            text="Your shoppingcart is empty"/>
        </template>
        <template v-else>

            <template v-if="success">
                <CheckoutSuccess/>
            </template>
            
            <template v-else>
                <v-row>
                    <v-col cols="12" class="d-flex flex-column align-center">
                        <v-icon class="display-3">mdi-shopping-outline</v-icon>
                        <div class="display-3">Checkout</div>
                    </v-col>
                </v-row>

                <v-row>
                    <v-col cols="12" sm="12" md="6" class="justify-center">
                        <CheckoutForm
                        @checkout-finished="checkoutFinished"
                        />
                    </v-col>
            
                    <v-col cols="12" sm="12" md="6">
                        <v-card flat :class="{'text-center mb-6': $vuetify.breakpoint.smAndDown}">
                            <ShoppingCartList
                            :cartItems="orders"
                            :totalItems="orders"
                            :displayLimit="false"
                            @update-cart="update"
                            />
                        </v-card>
                    </v-col>

                </v-row>
                
            </template>
        </template>
    </v-container>
</template>
<script>
import NothingToDisplay from '@/components/common/NothingToDisplay'
import CheckoutForm from '@/components/ui/CheckoutForm'
import CheckoutSuccess from '@/components/ui/CheckoutSuccess'
import ShoppingCartList from '@/components/ui/ShoppingCartList'

export default {
    name: 'Index',
    components: {
        NothingToDisplay,
        CheckoutForm,
        CheckoutSuccess,
        ShoppingCartList
    },
    data() {
        return {
            orders: [{}],
            success: false
        }
    },
    methods: {
        update(e) {
            this.orders = e;

        },
        checkoutFinished() {
            this.success = true
        },
        /*
        LocalStorage brukes som en primitiv "state-handler". Legger data fra
        LocalStorage i orders Arrayet 
        */
        getCartItems(){
            this.orders = JSON.parse(localStorage.getItem('orders'));
        },
    },
    created() {
        this.getCartItems()
    }
}
</script>