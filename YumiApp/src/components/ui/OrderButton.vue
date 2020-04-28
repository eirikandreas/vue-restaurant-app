<template>
    <div>
        <v-btn block depressed rounded color="amber accent-3" @click="placeOrder()">Order</v-btn>
    </div>
</template>
<script>
export default {
    name: 'OrderButton',
    props: {
      id: { type: Number, default: 0}
    },
    data() {
        return {
            menuItem: {}, 
            orderItem: {
                id: '',
                title: '',
                price: 0,
                quantity: 1,
            },

       

        }
    },
    methods: {
         getItem(item) {
            const webAPIUrl = `https://localhost:5001/user/menuitems/${item}`;
            this.$http.get(webAPIUrl)
                .then( response => {
                    this.menuItem = response.data;


                    this.orderItem.id = this.menuItem.id
                    this.orderItem.title = this.menuItem.title
                    this.orderItem.price = this.menuItem.price
                    this.orderItem.imgSrc = this.menuItem.imgSrc

                    
                    //this.menuItem = this.orderItem = {id: this.menuItem.id, title: this.menuItem.title, price: this.menuItem.price, quantity: 1}
                    

                    
                 
                });
        },
         placeOrder() {
            
            let orders = [];

            
            
            orders = JSON.parse(localStorage.getItem("orders")) || [];
            
            
            let orderIds = [];
            let newOrders = [];
            for(let i of orders) {
                orderIds.push(i.id)
                

            }
       
            if(!orderIds.includes(this.orderItem.id)) {
                newOrders.push(this.orderItem);

                orders.forEach( order => {
                        newOrders.push(order) 
                })

            } else {
                
                 orders.forEach( order => {
                     if(order.id != this.orderItem.id)
                        newOrders.push(order)
                })
                
                this.orderItem.quantity++
            
                newOrders.push(this.orderItem)
            }

            console.log(newOrders)


          
          

            


            localStorage.setItem("orders", JSON.stringify(newOrders));



        }
    },
    created() {
        this.getItem(this.id)

    }
    
}
</script>