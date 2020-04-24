<template>
    <div>

  

        <CartList
        title="Your Shoppingcart"
        :itemsArr="orders"/>

           <v-list>
              <v-list-item>    
                <v-list-item-content>
                  <v-list-item-title class="title font-weight-bold">Total:</v-list-item-title>
                </v-list-item-content>

                 <v-list-item-action>
                  <v-list-item-title class="title font-weight-bold">${{sum}}</v-list-item-title>
                </v-list-item-action>
              </v-list-item>
            </v-list>

            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn rounded depressed block color="amber accent-3" @click.stop="dialog = true">Place Order</v-btn>
            </v-card-actions>

    </div>
</template>
<script>
import CartList from './CartList'
export default {
    name: 'Index',
    components: {
        CartList
    },
    data() {
        return {
            orders: [{}],
            sum: 0
        }
    },
    methods: {
         getCartItems(){
        this.orders = JSON.parse(localStorage.getItem('orders'));
        console.log(this.orders)
       // this.calcCart()    
      },
    },
    created() {
        this.getCartItems()
    }
}
</script>