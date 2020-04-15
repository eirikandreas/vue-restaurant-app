<template>
<div>
    <template v-if="menuItems.length > 0">
      <Hero
      title="Order, eat and enjoy!"
      btnValue="View our Menu"
      :bgImage="heroBg"
      link="/menu"
      />
    </template>
<template v-else>
     <v-carousel
    tile
    cycle
    height="600px"
    hide-delimiter-background
    show-arrows-on-hover
    >
      <v-carousel-item
        v-for="(menuItem, i) in filterByFeatured()"
        :key="i"
        :src="`https:/localhost:5001/images/${menuItem.imgUrl}`"
      >
        <div class="overlay-gradient d-flex align-center">
    
          <v-container>
            <v-row>
              <v-col cols="12" sm="12" md="8">
                <h2 class="title white--text">Featured from our menu</h2>
                <h1 class="display-4 font-weight-bold white--text">{{menuItem.title}}</h1>
                <h2 class="title white--text">{{menuItem.category}}</h2>
                <p class="white--text mt-3">{{menuItem.description}} Lorem ipsum dolor sit amet, consectetur adipisicing elit. Natus esse pariatur labore aut autem odit accusantium ratione quam vel hic cumque, eius quae quo quas delectus libero reiciendis repellat perspiciatis!</p>
                <v-btn light rounded depressed color="amber accent-3" class="mt-5">View More</v-btn>
              </v-col>
            </v-row>
          </v-container>
        </div>   
      </v-carousel-item>
    </v-carousel>
  </template>
</div>
</template>
<script>
import Hero from '@/pages/HomePage/Hero'
export default {
    name: 'Carousel',
    components: {
      Hero
    },
     data () {
      return {
        heroBg: "herobg2.jpg",
        menuItems: [{}],
      }
    },
    methods: {
      filterByFeatured() {

        return this.menuItems.filter( menuItem => menuItem.isFeatured == "true")
       
      },
    },
    created(){
        
        let webAPIUrl = "https://localhost:5001/menuitems";
        this.$http.get( webAPIUrl )
            .then( result => {
                console.log( result.data );
                this.menuItems = result.data;
            } )



            
        }
}
</script>
<style scoped>
.overlay-gradient {
height: 600px;
background: -moz-linear-gradient(bottom, rgba(0,0,0,0.65) 0%, rgba(0,0,0,0) 100%); /* FF3.6-15 */
background: -webkit-linear-gradient(bottom, rgba(0,0,0,0.65) 0%,rgba(0,0,0,0) 100%); /* Chrome10-25,Safari5.1-6 */
background: linear-gradient(to top, rgba(0,0,0,0.65) 0%,rgba(0,0,0,0) 100%); /* W3C, IE10+, FF16+, Chrome26+, Opera12+, Safari7+ */
}
</style>