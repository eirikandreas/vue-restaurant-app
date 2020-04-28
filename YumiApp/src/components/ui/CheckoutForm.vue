<template>
    <div>

   
         <v-form   ref="form"
    v-model="valid">
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
                type="number"
                required
                color="red"
              ></v-text-field>

              <v-text-field
                :rules="reqRule"
                v-model="checkoutForm.subject"
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

              <v-btn :disabled="!valid" rounded depressed class="mr-4" color="amber accent-3" @click="validate()">Place Order</v-btn>
        
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
     
                comment: '',
   
                dateAdded: new Date().toDateString(),
            },
            emptyForm: {
                name: '',
                email: '',
                phoneNumber: null,
      
                comment: '',
 
                dateAdded: new Date().toDateString(),
            }

        }
    },
    methods: {
         validate () {
                if(this.$refs.form.validate() == true) {
                         this.postCartItems();
                } else {
                    this.$refs.form.validate()
                }
            },

        postCheckoutForm(){ 
    
        console.log(this.checkoutForm)
        let webAPIUrl = "https://localhost:5001/orders";
        this.$http.post(webAPIUrl, this.checkoutForm)
        .then(
        console.log("POST request firing "),
        localStorage.removeItem("orders")
        )
        .catch(err =>
        console.log(err))

        },
        success() {
          this.$emit('checkout-finished');

        },
       postCartItems(){
        let newOrder = {
        name: this.checkoutForm.name,
        email: this.checkoutForm.email,
        address: this.checkoutForm.address,
        comment: this.checkoutForm.comment,
        dateAdded: this.checkoutForm.dateAdded,
        items: localStorage.getItem("orders")
        }
        let webAPIUrl = "https://localhost:5001/orders";
        this.$http.post(webAPIUrl, newOrder)
        .then(
          this.success(),
        console.log("POST request firing "),
        localStorage.removeItem("orders")
        );

        },
    }
}
</script>