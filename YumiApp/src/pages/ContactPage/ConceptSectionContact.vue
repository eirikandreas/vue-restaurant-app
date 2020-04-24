<template>
  <section id="concept-section">
    <v-container>
      <v-row>
        <v-col cols="12" sm="12" md="6" class="justify-center pa-0">
          <v-img contain :src="require(`@/assets/images/${sectionConceptImg}`)" min-width="400px"></v-img>
        </v-col>

        <v-col cols="12" sm="12" md="6" class="d-flex align-center">


          <v-card flat :class="{'text-center mb-6': $vuetify.breakpoint.smAndDown}" >


            <v-card-title :class="[{'justify-center display-2': $vuetify.breakpoint.smAndDown}, 'display-3', 'font-weight-bold']">{{cardTitle}}</v-card-title>
            <v-card-text>{{cardText}}</v-card-text>
   
            <v-form>
              <v-text-field
                v-model="name"
                label="Name"
                required
                @input="$v.name.$touch()"
                @blur="$v.name.$touch()"
              ></v-text-field>

              <v-text-field
                v-model="epost"
                label="Email"
                required
                @input="$v.name.$touch()"
                @blur="$v.name.$touch()"
              ></v-text-field>

              <v-text-field
                v-model="phonenumber"
                label="Phonenumber"
                required
                @input="$v.email.$touch()"
                @blur="$v.email.$touch()"
              ></v-text-field>

              <v-text-field
                v-model="query"
                label="What can we do for you?"
                required
              ></v-text-field>

              <v-select
                v-model="select"
                :items="items"
                label="Resturant"
                required
                @change="$v.select.$touch()"
                @blur="$v.select.$touch()"
              ></v-select>

              <v-checkbox
                v-model="checkbox"
                :error-messages="checkboxErrors"
                label="Contact me by phone"
                required
                @change="$v.checkbox.$touch()"
                @blur="$v.checkbox.$touch()"
              ></v-checkbox>

              <v-btn class="mr-4" color="amber" @click="submit">Submit</v-btn>
        
            </v-form>
       

          </v-card>



        </v-col>

      </v-row>
    </v-container>
  </section>
</template>
<script>
export default {
    name: 'ConceptSection',
     props: {

        cardTitle: { type: String, default: "What can we do for you?" },
        cardText: { type: String, default: "Contact us and become our regular customer" },

       
    },
     data () {
      return {
        sectionConceptImg: 'concept-image-1-crop.png',
        colors: [
          'indigo',
          'warning',
          'pink darken-2',
          'red lighten-1',
          'deep-purple accent-4',
        ],
        slides: [
          'First',
          'Second',
          'Third',
          'Fourth',
          'Fifth',
        ],
        items: [
          'Yummi Oslo',
          'Yummi Bergen',
          'Yummi Trondheim',
          
        ]
      }
    },
}
</script>
<style scoped>
.round-img {
  border-radius: 50%;
}
</style>