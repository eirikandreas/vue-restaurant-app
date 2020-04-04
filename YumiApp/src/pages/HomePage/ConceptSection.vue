<template>
<section id="concept-section">
<v-container>
  <v-row>
    <v-col cols="12" sm="12" md="6" class="justify-center pa-0">
  <v-img contain :src="require(`@/assets/images/${sectionConceptImg}`)" min-width="400px">
  

  
  </v-img>
    </v-col>

    <v-col cols="12" sm="12" md="6" class="d-flex align-center">


      <v-card flat :class="{'text-center mb-6': $vuetify.breakpoint.smAndDown}" >


        <v-card-title :class="[{'justify-center display-2': $vuetify.breakpoint.smAndDown}, 'display-3', 'font-weight-bold']">Our concept</v-card-title>
        <v-card-text>
          Lorem ipsum dolor sit amet consectetur, adipisicing elit. Quaerat cupiditate fugiat laboriosam porro officiis asperiores temporibus illo nulla aliquam culpa vitae assumenda facere harum a, ipsum sit iste velit possimus!


        </v-card-text>
        <v-card-text>
 <v-btn depressed rounded large color="amber accent-3">About us</v-btn>
        </v-card-text>
       

      </v-card>



    </v-col>

  </v-row>
</v-container>
</section>
</template>
<script>
export default {
    name: 'ConceptSection',
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
      }
    },
}
</script>
<style scoped>
.round-img {
  border-radius: 50%;
}
</style>