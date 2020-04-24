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
        :index="index"
        @delete-item="deleteCartItem"
        />
          </v-list>
            <v-divider></v-divider>
            <template v-if="items.length > 5">
              <v-list-item class="justify-center">
                <v-list-item-content>
                  <v-btn rounded text>View all {{items.length}} items</v-btn>
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
    
    
    
    
    </div>






</template>
<script>
import CartItem from './ShoppingCartItem'
export default {
    name: 'CartList',
    props: {
        title: { type: String },
        itemsArr: { type: Array},
    },
    components: {
        CartItem
    },
    data() {
        return {
            items: [{}],
            sum: 0
        }
    },
    watch: {
        itemsArr () {
            this.items = this.itemsArr
        }
    },
    methods: {
        calcCart() {
        this.sum = 0
        this.itemsArr.forEach(item => {
        this.sum += item.price
        console.log("CALCULATING")
        }) 
        },
         deleteCartItem(index){
            this.items = JSON.parse(localStorage.getItem("orders"));
            this.items.splice(index, 1);
            localStorage.setItem("orders",JSON.stringify(this.items));
            this.calcCart()
        }
    },
    created(){
        this.calcCart()
        this.items = this.itemsArr
        
    }
}
</script>