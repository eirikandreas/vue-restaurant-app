<template>
  <section id="parallax-section">
    
    <v-parallax :height="`${height}`" width="500" dark :src="require(`@/assets/images/${bgImage}`)">
      
      <v-row
      align="center"
      justify="center"
      id="overlay-image"
      class="ml-n4 mr-n4"
      >

        <v-col class="text-center  d-flex flex-column align-center" cols="12">
          <v-img class="align-center" :src="require(`@/assets/icons/${icon}`)" width="64" height="64"></v-img>
          <h1 class="display-4 font-weight-thin mb-4">{{title}}</h1>
          <template v-if="showSub">
            <h4 class="subheading">{{subheading}}</h4>
          </template>
          <template v-if="showButton">
            <v-btn
            depressed 
            rounded 
            large 
            color="amber accent-3" 
            class="mt-5" 
            :to="`${link}`">
              {{buttonValue}}
            </v-btn>
          </template>
        </v-col>

      </v-row>
    </v-parallax>
    
   </section>
</template>
<script>
export default {
    name: 'ParallaxSection',
    props: {
      title: { type: String, default: "Not Set"},
      showSub: {type: Boolean, default: false},
      subheading: { type: String, default: "Not Set"},
      bgImage: { type: String, default: "parallax-5.jpg"},
      icon: { type: String, default: "takeaway-w.png"},
      showButton: {type: Boolean, default: false},
      buttonValue: {type: String, default: "Not Set"},
      link: {type: String, default: "#"},
      height: {type: Number, default: 300}
     
    },
}
</script>
<style scoped>
#overlay-image {
  background-color: rgba(0, 0, 0, 0.6);

}
</style>