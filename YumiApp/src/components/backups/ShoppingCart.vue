<template>
    <div>

      <v-menu offset-y close-on-click> 
      <template v-slot:activator="{ on }"> 
        <v-btn icon v-on="on" @click="getCartItems()">
          <v-icon class="white--text">mdi-shopping-outline</v-icon>
        </v-btn>
      </template>
<v-card min-width="400px" min-height="200px" class="d-flex flex-column align-content-center">
        <template v-if="orders.length === 0">

        <div class="text-center pt-8">
           <v-icon color="grey lighten-2" class="display-3">mdi-shopping-outline</v-icon>
           <v-card-text class="display-1">No Items</v-card-text>
        </div>
        </template>

        <template v-else>

  
  
        <ShoppingCartList
        title="Your Shoppingcart"
        :cartItems="orders"/>

        

            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn rounded depressed block color="amber accent-3" @click.stop="dialog = true">Place Order</v-btn>
            </v-card-actions>



             <v-divider></v-divider>
            <template v-if="orders.length > 5">
              <v-list-item class="justify-center">
                <v-list-item-content>
                  <v-btn rounded text>View all {{orders.length}} items</v-btn>
                </v-list-item-content>
              </v-list-item>
            </template>
            <v-divider></v-divider>
    
    
    
    
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



        </template>




</v-card>
            </v-menu>
   
    </div>
</template>
<script>
import ShoppingCartList from './ShoppingCartList'
export default {
    name: 'Index',
    components: {
        ShoppingCartList
    },
    data() {
        return {
            orders: [],
            sum: 0,
        }
    },
    methods: {
        getCartItems(){
        this.orders = JSON.parse(localStorage.getItem('orders'));
        console.log(this.orders)
        this.calcCart()    
      },
        calcCart() {
        this.sum = 0
        this.orders.forEach(item => {
        this.sum += item.price
        console.log("CALCULATING")
        }) 
        }
    },
    mounted() {
        this.getCartItems()
        
    }
}
</script>