<template>
    <div>
        <v-btn depressed rounded color="amber accent-3" class="ml-3" @click="placeOrder()">Order</v-btn>
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

        }
    },
    methods: {
         getItem(item) {
            const webAPIUrl = `https://localhost:5001/menuitems/${item}`;
            this.$http.get(webAPIUrl)
                .then( response => {
                    this.menuItem = response.data;
                    console.log(this.menuItem)
                });
        },
         placeOrder() {
            let orders = [];
            orders = JSON.parse(localStorage.getItem("orders")) || [];
            orders.push(this.menuItem);
            localStorage.setItem("orders", JSON.stringify(orders));

        }
    },
    created() {
        this.getItem(this.id)

    }
    
}
</script>