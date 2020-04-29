<template>
  <div>
    <v-list v-for="(item, index) in cartItems" :key="index">
          
      <ShoppingCartItem
      :image="item.imgSrc"
      :title="item.title"
      :price="item.price"
      :quantity="item.quantity"
      :index="index"
      @delete-item="deleteCartItem"
      :showDelete="showDelete"
      />
      
      <v-divider></v-divider>
    </v-list>

    <template v-if="displayLimit">   
      <v-list-item class="justify-center">
        <v-list-item-content>
          <v-btn rounded depressed color="amber accent-3" to="/checkout">View all ({{totalItems.length}})</v-btn>
        </v-list-item-content>
      </v-list-item>
    </template>

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
  </div>
</template>
<script>
import ShoppingCartItem from './ShoppingCartItem'
export default {
    name: 'ShoppingCartList',
    props: {
        title: { type: String },
        cartItems: { type: Array },
        totalItems: { type: Array },
        showDelete: { type: Boolean, default: true},
        displayLimit: { type: Boolean, default: true}
        
    },
    components: {
        ShoppingCartItem
    },
    data() {
        return {
            items: [{}],
            sum: 0,
            quantity: 0,     
        }
    },
    methods: {
        /* 
        Sett orders fra LocalStorage i items Arrayet,
        slett fra Arrayet, sett så Arrayet tilbake til LocalStorage
        */ 
        deleteCartItem(index){
          this.items = JSON.parse(localStorage.getItem("orders"));
          this.items.splice(index, 1);
          localStorage.setItem("orders",JSON.stringify(this.items));
        },
        //Kalkulerer totalsummen på innholdet i handlekurven.
        calcCart() {
          this.sum = 0
          this.cartItems.forEach(item => {
            this.sum += item.price
          }) 
        },
    },
    created(){
        this.items = this.cartItems
        this.calcCart()    
    }
}
</script>