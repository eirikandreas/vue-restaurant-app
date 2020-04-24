<template>
    <div>
    

      <Fitte
      title="fitte"/>


    </div>
</template>
<script>
import Fitte from './Fitte.vue'
export default {
    name: 'Cart',
    components: {
      Fitte
    },
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
    

            
        }

     },
     created() {
         this.getCartItems()
     }
}
</script>