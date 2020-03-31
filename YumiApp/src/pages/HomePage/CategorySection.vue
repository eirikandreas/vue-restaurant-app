<template>
   <v-container fluid class="pa-0" >
     <v-row class="no-gutters">
    




    <v-col cols="12" md="6" v-for="(category, i) in categories"
          :key="i">


 <v-hover v-slot:default="{ hover }">
<v-card tile :class="[{ 'on-hover': hover}, 'text-center']">

      <v-img :src="require(`@/assets/${category.image}`)" height="450px">
      
      
     
      <v-card-text class="display-3 font-weight-bold">
        
        {{category.name}}
      
      </v-card-text>
      </v-img>


</v-card>

 </v-hover>

    </v-col>








     </v-row>






   </v-container>
</template>
<script>
export default {
    name: 'Carousel',
     data () {
      return {
        textcenter: 'text-center',
        transparent: 'rgba(255, 255, 255, 0)',
        icons: ['mdi-rewind', 'mdi-play', 'mdi-fast-forward'],
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
         categories: [
           { name: 'Nigiri', image: '1.jpg'},
           { name: 'Maki', image: '2.jpg'},
           { name: 'Bowl', image: '3.jpg'},
           { name: 'Desserts', image: '4.jpg'},
        ],
      }
    },
}
</script>

<style scoped>
.v-card {
  transition: opacity .4s ease-in-out;
}

.v-card:not(.on-hover) {
  opacity: 0.6;
 }

.show-btns {
  color: rgba(255, 255, 255, 1) !important;
}
</style>