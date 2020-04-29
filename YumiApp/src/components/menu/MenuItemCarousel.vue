<template>
    <v-carousel
    tile
    cycle
    height="600px"
    hide-delimiter-background
    show-arrows-on-hover
    >
      <v-carousel-item
      v-for="(item, index) in items"
      :key="index"
      :src="`https:/localhost:5001/images/${item.imgSrc}`"
      >
        <div class="overlay-gradient d-flex align-center">
  
          <v-container>
            <v-row>
              <v-col cols="12" sm="12" md="8">
                <div class="title white--text">Featured from our menu</div>
                <h1 :class="{'display-2 font-weight-bold white--text': $vuetify.breakpoint.xsOnly, 'display-4 font-weight-bold white--text': $vuetify.breakpoint.smAndUp}">{{item.title}}</h1>
                <h2 class="title white--text">{{item.category}}</h2>
                <p class="white--text mt-3">{{item.description}}</p>
                <v-btn light rounded depressed color="amber accent-3" class="mt-5"  :to="`/menu/${item.category.toLowerCase()}/${item.id}#category`">View More</v-btn>
              </v-col>
            </v-row>
          </v-container>

        </div>
      </v-carousel-item>
    </v-carousel>
</template>
<script>
export default {
    name: 'MenuItemCarousel',
    props: {
        items: { type: Array },
    }
}
</script>