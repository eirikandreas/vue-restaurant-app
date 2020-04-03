<template>
     <div>


  <v-parallax height="300" width="500" dark :src="require(`@/assets/images/${sectionParallaxImg}`)">
    <v-row
      align="center"
      justify="center"
       id="overlay-image"
       class="ml-n4 mr-n4"
    >
      <v-col class="text-center  d-flex flex-column align-center" cols="12">
        <v-img class="align-center" :src="require(`@/assets/icons/${sectionParallaxIcon}`)" width="64" height="64"></v-img>
        <h1 class="display-4 font-weight-thin mb-4">Our menu</h1>
      </v-col>
    </v-row>
  </v-parallax>
<v-container>
  <MenuList
  :displayItems="display"
  />
</v-container>

     </div>
</template>
<script>
import MenuList from '@/components/MenuList.vue'

export default {
    name: 'Menu',
    components: {
        MenuList
    },
       data () {
      return {
        display: 4,
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