<template>
     <div>




            <v-badge light top color="red accent-3" overlap offset-x="20" offset-y="20" :content="`${orders.length}`">
            <v-menu offset-y>
                <template v-slot:activator="{ on }"> 
                    <v-btn icon v-on="on">
                        <v-icon class="white--text">mdi-shopping-outline</v-icon>
                    </v-btn>
                </template>

        <v-card>
          <v-list>
            <v-list-item>
              <v-list-item-content>
                <v-list-item-title class="title font-weight-bold">Your shoppingcart</v-list-item-title>
                <v-list-item-subtitle>Items: {{ orders.length }}</v-list-item-subtitle>
              </v-list-item-content>

              <v-list-item-action>
                  <v-icon>mdi-shopping-outline</v-icon>
              </v-list-item-action>
            </v-list-item>
          </v-list>

            <v-list v-for="item in orders"
            :key="item.id">

              <v-divider></v-divider>

              <v-list-item>
                  <!--
                <v-list-item-avatar>
                  <v-img :src="require(`@/assets/${item.imgUrl}`)"></v-img>
                </v-list-item-avatar>

                -->
                <v-list-item-content>
                  <v-list-item-title>{{ item.title }} </v-list-item-title>
                  <v-list-item-subtitle>
                    Quantity 
                    <v-btn text small rounded> {{ item.quantity }} <v-icon>mdi-chevron-down</v-icon></v-btn>
                  </v-list-item-subtitle>
                  <v-list-item-subtitle>Price {{ item.price }}</v-list-item-subtitle>
                </v-list-item-content>
          
                <v-btn icon>
                  <v-icon small>mdi-close</v-icon>
                </v-btn>
            
              </v-list-item>
            </v-list>

            <v-list>

              <v-divider></v-divider>

              <v-list-item>    
                <v-list-item-content>
                  <v-list-item-title class="title font-weight-bold">Total:</v-list-item-title>
                </v-list-item-content>
                 <v-list-item-action>
                  <v-list-item-title class="title font-weight-bold">$16</v-list-item-title>
                </v-list-item-action>
              </v-list-item>
            </v-list>

          <v-card-actions>

            <v-spacer></v-spacer>

            <v-btn rounded depressed block color="amber accent-3" @click="menu = false">Order</v-btn>
          </v-card-actions>
        </v-card>
            
      </v-menu>
    </v-badge>



     </div>
</template>
<script>
export default {
    name: 'ShoppingCart',
    data() {
        return {
            orders: []

        }
    },
      mounted() {
    if (localStorage.getItem('orders')) {
      try {
        this.orders = JSON.parse(localStorage.getItem('orders'));
        console.log(this.orders);
      } catch(e) {
        localStorage.removeItem('orders');
      }
    }
      },
    methods: {
        getCartItems(){
    

            
        }
    },
    
    created(){
        console.log("FUNKERE?" + this.orders)
        this.getCartItems()
    }
    
}
</script>