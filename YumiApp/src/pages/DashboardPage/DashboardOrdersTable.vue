<template>
  <div>
    <v-toolbar flat color="transparent">
      <v-toolbar-title class="headline ml-n4">Orders ({{orders.length}})</v-toolbar-title>
    </v-toolbar>

    <v-card class="mb-5">

      <v-data-table
      :headers="headers"
      :items="orders"
      class="elevation-1"
      >

      <template v-slot:item.actions="{ item }">
        <v-btn depressed color="amber accent-3" class="text-center" @click="openOrder(item)" fab x-small dark>
          <v-icon fab small>mdi-eye</v-icon>
        </v-btn>
      </template>

      </v-data-table>
    </v-card>

<!-- DIALOG -->
  
  <OrderDialog
  :active="dialog"
  :order="order"
  :orderItems="orderItems"
  @delete-order="deleteOrder"
  @close-dialog="closeDialog"
  />
  


  </div>  
</template>
<script>
import OrderDialog from '@/components/dashboard/OrderDialog'
export default {
    name: 'DashboardOrdersTable',
    components: {
      OrderDialog

    },
     data () {
      return {
        dialog: false,
        expanded: [],
        headers: [
          {
            text: 'Id',
            align: 'start',
            sortable: false,
            value: 'id',
          },
          { text: 'Name', value: 'name' },
          { text: 'Price', value: 'totalPrice' },
          { text: 'Added', value: 'dateAdded' },
          { text: 'Actions', value: 'actions' },
          { text: '', value: 'data-table-expand', sortable: false },
        ],
        orders: [{}],
        order: {},
        orderItems: [{}]
      }
    },
    methods: {
      init() {
        this.loading = true
        const webAPIUrl = "https://localhost:5001/orders/";
        this.$http.get(webAPIUrl)
          .then(response => {
            this.orders = response.data,
       
            console.log(this.orders)
            this.loading = false
          })
        },
        openOrder(item){
          this.order = item
          this.orderItems = JSON.parse(this.order.items)
          console.log(this.orderItems)
          this.dialog = true
          console.log(item)
        },
        deleteOrder(item) {
        const index = this.orders.indexOf(item)
        this.orders.splice(index, 1)
        let webAPIUrl = `https://localhost:5001/orders/${item.id}`;
        this.$http.delete(webAPIUrl)
            .then(
            this.dialog = false
            )
        },
        closeDialog() {
          this.dialog = false
        }
    },
    created() {
      this.init()
    }
    
}
</script>