<template>
    <div>
      <v-menu offset-y close-on-click> 
        <template v-slot:activator="{ on }"> 
          <v-btn icon v-on="on" @click="getCartItems()">
            <v-icon class="white--text">mdi-shopping-outline</v-icon>
          </v-btn>
        </template>

        <v-card min-width="400px" min-height="200px" class="d-flex flex-column align-content-center">

          <template v-if="!orders">
            <div class="text-center pt-8">
              <v-icon color="grey lighten-2" class="display-3">mdi-shopping-outline</v-icon>
              <v-card-text class="display-1">No Items</v-card-text>
            </div>
          </template>

        <template v-else>
          <v-list>
            <v-list-item>
              <v-list-item-content>
                <v-list-item-title class="title font-weight-bold">Shoppingcart</v-list-item-title>
              </v-list-item-content>

              <v-list-item-action>
                <v-badge light top color="red accent-3" overlap offset-x="10" offset-y="10" :content="`${orders.length}`">
                  <v-icon>mdi-shopping-outline</v-icon>
                </v-badge>
              </v-list-item-action>
            </v-list-item>
          </v-list>

        <ShoppingCartList
        :cartItems="limitedOrder"
        :totalItems="orders"
        :showDelete="false"
        />

    

            <v-divider></v-divider>

  

         

        </template>
      </v-card>
    </v-menu>
  </div>
</template>
<script>
import ShoppingCartList from '@/components/ui/ShoppingCartList'
export default {
    name: 'Index',
    components: {
      ShoppingCartList
    },
    data() {
        return {
            orders: [{}],
            limitedOrder: [{}],
            sum: 0,
        }
    },
   methods: {
        limitCartItems(){
        this.limitedOrder = this.orders.slice(0, 3)
        },
        getCartItems(){
        this.orders = JSON.parse(localStorage.getItem('orders'));
        this.limitCartItems()
  
        },
        postCartItems(){
        let newOrder = {
        items: localStorage.getItem("orders")
        }
        let webAPIUrl = "https://localhost:5001/user/orders";
        this.$http.post(webAPIUrl, newOrder)
        .then(
        console.log("POST request firing "),
        localStorage.removeItem("orders")
        );

        },
    },


    mounted() {
        this.getCartItems()
        
    }
}
</script>