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
                });
        },
        placeOrder() {
            let orders = [];
            orders = JSON.parse(localStorage.getItem("orders")) || [];
            let newOrder = true;
            
            /*
            Sjekker om den nye bestillingen er i listen fra før, dersom den er det
            oppdater antall og pris.
            */
            for(let item of orders) {
                if(this.orderItem.id == item.id) {
                    item.quantity++;
                    item.price = item.quantity * this.menuItem.price
                    newOrder = false
                    break;
                }
            }

            if(newOrder) {
                orders.push(this.orderItem)
            }

            localStorage.setItem("orders", JSON.stringify(orders));
        }
    },
    created() {
        this.getItem(this.id)

    }  
}
</script>