<template>

   <section id="parallax-section-contact">



  <v-parallax height="500" width="500" dark :src="require(`@/assets/images/${sectionParallaxImg}`)">
    <v-row
      align="center"
      justify="center"
       id="overlay-image"
       class="ml-n4 mr-n4"
    >
      <v-col class="text-center  d-flex flex-column align-center" cols="12">
        <v-img class="align-center" :src="require(`@/assets/icons/${sectionParallaxIcon}`)" width="64" height="64"></v-img>
        <h1 class="display-4 font-weight-thin mb-4">Verv en venn</h1>
        <h4 class="subheading">Verv en venn og få gratis frakt på din neste ordre</h4>
        <v-btn depressed rounded large color="amber accent-3" class="mt-5">Verv en venn</v-btn>
      </v-col>
    </v-row>
  </v-parallax>



   </section>
</template>
<script>
export default {
    name: 'ParallaxSectionContact',
     data () {
      return {
        sectionParallaxImg: 'parallax-5.jpg',
        sectionParallaxIcon: 'takeaway-w.png',
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