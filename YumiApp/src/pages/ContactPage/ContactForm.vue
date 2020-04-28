<template>
    <div>
        <template v-if="success">

      <v-alert
      dense
      text
      type="success"
    >
      Your message has been sent! We will contact you shortly!
    </v-alert>
        </template>
        <template v-else>
         <v-form   ref="form"
    v-model="valid">
              <v-text-field
                :rules="reqRule"
                v-model="contactForm.name"
                label="Name"
                required
                color="red"
              ></v-text-field>

              <v-text-field
                :rules="reqRule"
                v-model="contactForm.email"
                label="Email"
                required
                color="red"
              ></v-text-field>

              <v-text-field
                :rules="reqRule"
                v-model="contactForm.phoneNumber"
                label="Phonenumber"
                required
                color="red"
              ></v-text-field>

              <v-text-field
                :rules="reqRule"
                v-model="contactForm.subject"
                label="Subject"
                required
                color="red"
              ></v-text-field>

              <v-textarea
                :rules="reqRule"
                v-model="contactForm.comment"
                label="What can we do for you?"
                required
                color="red"
              ></v-textarea>

              <v-checkbox
                v-model="contactForm.contactByPhone"
                label="Contact me by phone"
                required
                color="red"
              ></v-checkbox>

              <v-btn :disabled="!valid" rounded depressed class="mr-4" color="amber accent-3" @click="validate()">Submit</v-btn>
        
            </v-form>
        </template>
    </div>
</template>
<script>
export default {
    name: 'ContactForm',
    data() {
        return {
            valid: true,
            reqRule: [
                v => !!v || 'This field is required'
            ],
            success: false,
            contactForm: {
                name: '',
                email: '',
                phonenumber: '',
                subject: '',
                comment: '',
                contactByPhone: false,
                dateSent: new Date().toDateString(),
                isRead: false,

            },
            emptyForm: {
                name: '',
                email: '',
                phonenumber: '',
                subject: '',
                comment: '',
                contactByPhone: false,
                dateSent: new Date().toDateString(),
                isRead: false,

            }

        }
    },
    methods: {
         validate () {
                if(this.$refs.form.validate() == true) {
                         this.postContactForm();
                } else {
                    this.$refs.form.validate()
                }
            },

               postContactForm(){
          let webAPIUrl = "https://localhost:5001/user/contactmessages";
                this.$http.post(webAPIUrl, this.contactForm)
                    .then(
         
                        console.log("POST request firing "),
                        this.contactForm = this.emptyForm,
                        this.success = true
              
                    );

        },
    }
}
</script>