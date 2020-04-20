<template>
  <div>
    
    <v-menu offset-y close-on-click> 
      <template v-slot:activator="{ on }"> 
        <v-btn icon v-on="on" @click="getCartItems()">
          <v-icon class="white--text">mdi-shopping-outline</v-icon>
        </v-btn>
      </template>
           
        <v-card min-width="400px">
          <v-list>
            <v-list-item>
              <v-list-item-content>
                <v-list-item-title class="title font-weight-bold">Your shoppingcart</v-list-item-title>
              </v-list-item-content>

              <v-list-item-action>
                         <v-badge light top color="red accent-3" overlap offset-x="10" offset-y="10" :content="`${orders.length}`">
                  <v-icon>mdi-shopping-outline</v-icon>
                         </v-badge>
              </v-list-item-action>
            </v-list-item>
          </v-list>
          
          <v-list v-for="(order, index) in orders.slice(0, 5)" :key="index">
            <v-divider></v-divider>
            <v-list-item>
              <v-list-item-avatar>
                <v-img :src="`https://localhost:5001/images/${order.imgSrc}`"></v-img>
              </v-list-item-avatar>

              <v-list-item-content>
                <v-list-item-title>{{ order.title }} </v-list-item-title>
                <v-list-item-subtitle>Price ${{ order.price }}</v-list-item-subtitle>
              </v-list-item-content>
        
              <v-btn icon @click.stop="deleteCartItem(index)">
                <v-icon small>mdi-close</v-icon>
              </v-btn>
            
            </v-list-item>

          </v-list>
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

            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn rounded depressed block color="amber accent-3" @click.stop="dialog = true">Place Order</v-btn>
            </v-card-actions>
        </v-card>
            
    </v-menu>

    <v-dialog v-model="dialog" persistent max-width="490">
      <v-card>
        <v-card-title class="headline">Your order</v-card-title>
        <v-card-text>Let Google help apps determine location. This means sending anonymous location data to Google, even when no apps are running.</v-card-text>
        <v-card-actions>
          <v-spacer></v-spacer>
            <v-btn rounded depressed color="amber accent-3" @click="dialog = false">Cancel</v-btn>
            <v-btn rounded depressed color="amber accent-3" @click="dialog = false">Place Order</v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>
    
  </div>
</template>
<script>
export default {
    name: 'ShoppingCart',
    data() {
        return {
            orders: [],
            sum: 5,
            dialog: false
        }
    },
    methods: {
      calcCart() {
        this.sum = 0
        this.orders.forEach(order => {
        this.sum += order.price
        }) 
      },
      getCartItems(){
        this.orders = JSON.parse(localStorage.getItem('orders'));
        this.calcCart()    
      },
      deleteCartItem(index){
        this.orders = JSON.parse(localStorage.getItem("orders"));
        this.orders.splice(index);
        localStorage.setItem("orders",JSON.stringify(this.orders));
        this.calcCart()
      }

    },
    created(){

    }
    
    
}
</script>