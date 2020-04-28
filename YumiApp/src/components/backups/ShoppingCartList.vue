<template>
    






        <div>



                   <v-list>
            <v-list-item>
              <v-list-item-content>
                <v-list-item-title class="title font-weight-bold">{{title}}</v-list-item-title>
              </v-list-item-content>

              <v-list-item-action>
                         <v-badge light top color="red accent-3" overlap offset-x="10" offset-y="10" :content="`${items.length}`">
                  <v-icon>mdi-shopping-outline</v-icon>
                         </v-badge>
              </v-list-item-action>
            </v-list-item>
          </v-list>
      



        <v-list>
          
        <CartItem
        v-for="(item, index) in items" 
        :key="index"
        :image="item.imgSrc"
        :title="item.title"
        :price="item.price"
        :quantity="item.quantity"
        :index="index"
        @delete-item="deleteCartItem"
        />
        </v-list>
         
    
    
    
    
    </div>






</template>
<script>
import CartItem from './ShoppingCartItem'
export default {
    name: 'CartList',
    props: {
        title: { type: String },
        cartItems: { type: Array},
    },
    components: {
        CartItem
    },
    data() {
        return {
            items: [{}],
            sum: 0,
            quantity: 0
        }
    },
    watch: {
        cartItems () {
            this.items = this.cartItems
        }
    },
    methods: {
    
         deleteCartItem(index){
            this.items = JSON.parse(localStorage.getItem("orders"));
            this.items.splice(index, 1);
            localStorage.setItem("orders",JSON.stringify(this.items));
  
        }
    },
    created(){
    
        this.items = this.cartItems
        
    }
}
</script>