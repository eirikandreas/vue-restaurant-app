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

          <v-list v-for="(item, index) in orders" :key="index">
            <v-divider></v-divider>
            <v-list-item>
                <v-list-item-avatar>
                  <v-img :src="`https://localhost:5001/images/${item.imgSrc}`"></v-img>
                </v-list-item-avatar>

                <v-list-item-content>
                  <v-list-item-title>{{ item.title }} </v-list-item-title>
                  <v-list-item-subtitle>Price ${{ item.price }}</v-list-item-subtitle>
                  <v-list-item-subtitle>Quantity {{ item.quantity }}</v-list-item-subtitle>
                </v-list-item-content>
          
                <v-btn icon @click.stop="deleteCartItem(index)">
                  <v-icon small>mdi-close</v-icon>
                </v-btn>
              </v-list-item>
         
            </v-list>
    
            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn rounded depressed block color="amber accent-3" @click.stop="postCartItems()">Place Order</v-btn>
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

export default {
    name: 'Index',
    data() {
        return {
            orders: [{}],
            sum: 0,
        }
    },
    methods: {
        getCartItems(){
        this.orders = JSON.parse(localStorage.getItem('orders'));
        this.calcCart()    
      },
           deleteCartItem(index){
            this.orders = JSON.parse(localStorage.getItem("orders"));
            this.orders.splice(index, 1);
            localStorage.setItem("orders",JSON.stringify(this.orders));
  
        },
        calcCart() {
        this.sum = 0
        this.orders.forEach(item => {
        this.sum += item.price
        }) 
        },

        postCartItems(){
        let newOrder = {
          items: localStorage.getItem("orders")
        }
        let webAPIUrl = "https://localhost:5001/orders";
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