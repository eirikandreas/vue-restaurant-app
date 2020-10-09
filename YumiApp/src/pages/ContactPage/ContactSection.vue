<template>
  <section id="concept-section">
    <v-container>
      <v-row>
        <v-col cols="12" sm="12" md="6" class="hidden-sm-and-down justify-center pa-0">
          <v-img contain :src="require(`@/assets/images/${contactImage}`)" min-width="400px"></v-img>
        </v-col>

        <v-col cols="12" sm="12" md="6" class="d-flex align-center">
          <v-card flat :class="{'mx-auto text-center mb-6': $vuetify.breakpoint.smAndDown}" >

            <v-card-title :class="[{'justify-center display-2': $vuetify.breakpoint.smAndDown}, 'display-3', 'font-weight-bold']">{{cardTitle}}</v-card-title>
            <v-card-text>{{cardText}}</v-card-text>

            <v-card-text>
            
              <ContactForm/>
                
            </v-card-text>
    
          </v-card>
        </v-col>

      </v-row>
    </v-container>
  </section>
</template>
<script>
import ContactForm from '@/pages/ContactPage/ContactForm'
export default {
    name: 'ContactSection',
    props: {
      cardTitle: { type: String, default: "What can we do for you?" },
      cardText: { type: String, default: "Contact us and become our regular customer" }
    },
    components: {
      ContactForm
    },
     data () {
      return {
        contactImage: 'concept-image-1-crop.png',
      }
    },
}
</script>
<style scoped>
.round-img {
  border-radius: 50%;
}
</style>