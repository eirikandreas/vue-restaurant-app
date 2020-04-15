<template>
     <div>




                   <v-menu offset-y> 
            
            
             
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

            <v-list v-for="(order, index) in orders.slice(0, 5)"
            :key="index">

              <v-divider></v-divider>

              <v-list-item>
          
                <v-list-item-avatar>
                  <v-img :src="`https://localhost:5001/images/${order.imgUrl}`"></v-img>
                </v-list-item-avatar>

        
                <v-list-item-content>
                  <v-list-item-title>{{ order.title }} </v-list-item-title>
           
                  <v-list-item-subtitle>Price ${{ order.price }}</v-list-item-subtitle>
                </v-list-item-content>
          
                <v-btn icon>
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

            <v-btn rounded depressed block color="amber accent-3" @click="menu = false" to="/cart">Order</v-btn>
          </v-card-actions>
        </v-card>
            
      </v-menu>




     </div>
</template>
<script>
export default {
    name: 'ShoppingCart',
    data() {
        return {
            orders: [],
            sum: 5,

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

    
    
    created(){

    }
    }
    
}
</script>