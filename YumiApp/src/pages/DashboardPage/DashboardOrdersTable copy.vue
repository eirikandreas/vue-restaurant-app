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
  
  <v-dialog v-model="dialog" max-width="600px">

    <v-card class="mx-auto">
      <v-sheet tile color="grey lighten-3">
        <v-row>

            <v-col cols="12" sm="12" class="pt-0 pb-0 d-flex">
                <v-card-title>Order ID: 1</v-card-title>
                <v-spacer></v-spacer>
                <v-card-title>Order Date: 25 April</v-card-title>
            </v-col>

        </v-row>
      </v-sheet>

      <v-divider></v-divider>

      <v-row>
        <v-col cols="12" sm="12">
          <v-list>
            <v-list-item>
              
              <v-list-item-content>
                <v-list-item-title class="title">Name: </v-list-item-title>
              </v-list-item-content>

              <v-list-item-content>
                <v-list-item-title class="d-flex justify-end">Ola Nordmann </v-list-item-title>
              </v-list-item-content>

            </v-list-item>

            <v-list-item>
              
              <v-list-item-content>
                <v-list-item-title class="title">Email: </v-list-item-title>
              </v-list-item-content>

              <v-list-item-content>
                <v-list-item-title class="d-flex justify-end">Ola Nordmann </v-list-item-title>
              </v-list-item-content>

            </v-list-item>

                     <v-list-item>
              
              <v-list-item-content>
                <v-list-item-title class="title">Phonenumber: </v-list-item-title>
              </v-list-item-content>

              <v-list-item-content>
                <v-list-item-title class="d-flex justify-end">Ola Nordmann </v-list-item-title>
              </v-list-item-content>

              

                </v-list-item>

                <v-list-item>
               <v-list-item-content>
                <v-list-item-title class="title">Address: </v-list-item-title>
              </v-list-item-content>

              <v-list-item-content>
                <v-list-item-title class="d-flex justify-end">Ola Nordmann </v-list-item-title>
              </v-list-item-content>

             </v-list-item>
      
          </v-list>
        </v-col>

       

      </v-row>
        <v-divider></v-divider>
       <v-row>

          <v-col cols="12" sm="12">
            <v-card-title>Order:</v-card-title>
             <v-list v-for="(item, index) in orderItems" :key="index">

                 <v-list-item>
                   
        <v-list-item-avatar>
          <v-img :src="`https://localhost:5001/images/${item.imgSrc}`"></v-img>
        </v-list-item-avatar>

        <v-list-item-content>
          <v-list-item-title v-text="item.title"></v-list-item-title>
        </v-list-item-content>

           <v-list-item-content>
          <v-list-item-title class="d-flex justify-end">Quantity: {{item.quantity}}</v-list-item-title>
        </v-list-item-content>

     

    
      </v-list-item>
      <v-divider></v-divider>
     

            </v-list>
    

        </v-col>
      </v-row>



       <v-row>

          <v-col cols="12" sm="12">
            <v-card-title>Comment:</v-card-title>
            <v-card-text>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Suscipit, cum.</v-card-text>

        </v-col>
      </v-row>

    <v-divider></v-divider>
<v-card-actions>
    <v-spacer></v-spacer>

     <v-btn rounded depressed color="amber accent-3" @click="closeDialog">Cancel</v-btn>

    <v-btn rounded depressed color="amber accent-3" @click="finishOrder(order)">Finished</v-btn>
</v-card-actions>
    </v-card>
  </v-dialog>
  


  </div>  
</template>
<script>
export default {
    name: 'DashboardOrdersTable',
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
          { text: 'Added', value: 'dateAdded' },
          { text: 'Status', value: 'isFinished' },
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
        finishOrder(item) {
        const index = this.orders.indexOf(item)
        this.orders.splice(index, 1)
        let webAPIUrl = `https://localhost:5001/orders/${item.id}`;
        this.$http.delete(webAPIUrl)
            .then(
            console.log("Deleted order with ID: " + item.id),
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
<style scoped>
.height {
  height: 100px;
}
</style>