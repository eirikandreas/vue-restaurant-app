<template>
  <div>
    <ParallaxSection
    title="Our Menu"
    :icon="pageIcon"/>
    <Search/>
     <Categories/>

    <v-container>
      <router-view/>
    </v-container>

  </div>     
</template>
<script>
import ParallaxSection from '@/components/ParallaxSection'
import Categories from '@/components/Categories'
import Search from '@/components/Search'

export default {
    name: 'Menu',
    components: {
      ParallaxSection,
      Search,
      Categories
    },
    data () {
      return {
        pageIcon:"icons/menu.png",
        menuItems: [{}],
        searchTerm: "",
      }
    }, 
    methods: {
      getAll(){
      let webAPIUrl = "https://localhost:5001/menuitems";
      this.$http.get( webAPIUrl )
        .then( result => {
          console.log( result.data );
          this.menuItems = result.data;
        })            
      }
    },
    created(){
      this.getAll()
    }
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