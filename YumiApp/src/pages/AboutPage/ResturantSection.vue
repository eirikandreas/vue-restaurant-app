<template>

   <section id="parallax-section">



  <v-parallax height="300" width="500" dark :src="require(`@/assets/images/${resturantSectionImg}`)">
    <v-row
      align="center"
      justify="center"
       id="overlay-image"
       class="ml-n4 mr-n4"
    >
      <v-col class="text-center  d-flex flex-column align-center" cols="12">
        <v-img class="align-center" :src="require(`@/assets/icons/${resturantSectionIcon}`)" width="50" height="50"></v-img>
        <h1 class="display-3 font-weight-thin mb-4">{{title}}</h1>
        <h4 class="subheading">{{text}}</h4>
        <v-btn depressed rounded large color="amber accent-3" class="mt-5">{{btnValue}}</v-btn>
      </v-col>
    </v-row>
  </v-parallax>



   </section>
</template>
<script>
export default {
    name: 'ResturantSection',
    props: {
        resturantSectionIcon: { type: String, default: "noodles.png" },
        resturantSectionImg: { type: String, default: "resturant.jpg" },
        title: { type: String, default: "Title" },
        text: { type: String, default: "Write text here" },
        btnValue: { type: String, default: "Click Here" },

        

    },
     data () {
      return {
        
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
#overlay-image {
  background-color: rgba(0, 0, 0, 0.6);

}
.v-parallax__content {
    padding: 0;
}
</style>