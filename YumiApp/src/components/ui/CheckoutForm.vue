<template>
  <div>
    <v-form ref="form" v-model="valid">
      <v-text-field
      :rules="reqRule"
      v-model="checkoutForm.name"
      label="Name"
      required
      color="red"
      ></v-text-field>

      <v-text-field
      :rules="reqRule"
      v-model="checkoutForm.email"
      label="Email"
      required
      color="red"
      ></v-text-field>

      <v-text-field
      :rules="reqRule"
      v-model="checkoutForm.phoneNumber"
      label="Phonenumber"
      required
      color="red"
      ></v-text-field>

      <v-text-field
      :rules="reqRule"
      v-model="checkoutForm.address"
      label="Address"
      required
      color="red"
      ></v-text-field>

      <v-textarea
      :rules="reqRule"
      v-model="checkoutForm.comment"
      label="Something we need to know?"
      required
      color="red"
      ></v-textarea>

      <v-btn
      :disabled="!valid"
      rounded 
      depressed 
      class="mr-4" 
      color="amber accent-3" 
      @click="validate()">
        Place Order
      </v-btn>  
    </v-form> 
  </div>
</template>
<script>
export default {
  name: 'CheckoutForm',
  props: {
    checkoutFinished: {type: Object}
  },
  data() {
    return {
      valid: true,
      reqRule: [
        v => !!v || 'This field is required'
      ],
      checkoutForm: {
        name: '',
        email: '',
        phoneNumber: '',
        address: '',
        comment: '',
        dateAdded: new Date().toDateString(),
      },
      emptyForm: {
        name: '',
        email: '',
        phoneNumber: '',
        address: '',
        comment: '',
        dateAdded: new Date().toDateString(),
      },
      sum: 0,
    }
  },
  methods: {
    /*
    Validerer Form, dersom valideringen går gjennom
    legg till i databasen.
    */
    validate () {
      if(this.$refs.form.validate() == true) {
        this.postCartItems();
      } else {
        this.$refs.form.validate()
      }
    },
    calcCart() {
      let orders = JSON.parse(localStorage.getItem('orders'));
      this.sum = 0
      orders.forEach(item => {
      this.sum += item.price
      }) 
    },
    success() {
          this.$emit('checkout-finished');
    },
    postCartItems(){
      this.calcCart()

      let totalPrice = this.sum.toString()

      let newOrder = {
        name: this.checkoutForm.name,
        email: this.checkoutForm.email,
        phoneNumber: this.checkoutForm.phoneNumber,
        address: this.checkoutForm.address,
        comment: this.checkoutForm.comment,
        dateAdded: this.checkoutForm.dateAdded,
        totalPrice: totalPrice,
        items: localStorage.getItem("orders")
      }
      
      let webAPIUrl = "https://localhost:5001/user/orders";
      this.$http.post(webAPIUrl, newOrder)
        .then(
          this.success(),
          localStorage.clear("orders")
        );
    },
  }
}
</script>