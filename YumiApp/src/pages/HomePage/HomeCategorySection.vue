<template>
  <section class="section-bg">

    <v-container fluid class="pa-0">
      <v-row class="no-gutters">
        <v-col cols="12" sm="6" md="3" lg="3"  v-for="category in categories" :key="category.id">
          <v-card tile class="text-center">
            <v-hover v-slot:default="{ hover }">
              <v-img :src="require(`@/assets/${category.imgSrc}`)" height="450px">
                <div id="overlay-image" :class="[{ 'on-hover': hover}, 'd-flex', 'align-center', 'fill-height']">
                  <v-card-text class="display-2 white--text font-weight-bold d-flex flex-column align-center">
                    <v-img :src="require(`@/assets/icons/${category.whiteIcon}`)" width="72px" height="72px" class="mb-3 icon-opacity"></v-img>
                    {{category.name}}
                    <v-btn 
                    id="hover-btn" 
                    :class="[{ 'show-btns mt-6': hover }]" 
                    depressed 
                    rounded 
                    width="150px" 
                    :to="`/menu/${category.name.toLowerCase()}`"
                    >
                    View more
                    </v-btn>
                  </v-card-text>
                </div>
                  </v-img>
            </v-hover>
            </v-card>
        </v-col>
      </v-row>
   </v-container>

</section>
</template>
<script>
export default {
    name: 'HomeCategorySection',
     data () {
      return {
        categories: this.$categories.getAll().slice(1, 5),
        textcenter: 'text-center',
        transparent: 'rgba(255, 255, 255, 0)',
        amber: '#ffc400',
      }
    },
    created() {
      console.log(this.categories)
    }
    
}
</script>
<style scoped>
.section-bg{
  background-color: #111111;
}
#overlay-image {
  transition: .4s ease-in-out;
  background-color: rgba(0, 0, 0, 0.3);
}

.overlay{
  background-color: rgba(0, 0, 0, 0.6);
}

 #overlay-image:not(.on-hover) {
   background-color: rgba(0, 0, 0, 0.6);
 }

.imgColor {
  background-color: red;
}

#hover-btn:not(.show-btns) {
  color: rgba(255, 255, 255, 0) !important;
  background-color: rgba(255, 255, 255, 0) !important;
  transition: .4s ease-in-out;
}

.show-btns {
  color: rgba(0, 0, 0, 1) !important;
  background-color: #ffc400 !important;
  transition: .4s ease-in-out;
}
</style>