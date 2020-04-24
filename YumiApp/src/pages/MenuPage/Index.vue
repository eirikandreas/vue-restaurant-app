<template>
  <div>
    <ParallaxSection
    title="Our Menu"
    :icon="pageIcon"/>

    <SearchField/>
    <MenuCategories/>

    <v-container>
      <router-view/> 
    </v-container>

  </div>     
</template>
<script>
import ParallaxSection from '@/components/ui/ParallaxSection'
import SearchField from '@/components/ui/SearchField'

import MenuCategories from '@/components/menu/MenuCategories'



export default {
    name: 'Index',
    components: {

      ParallaxSection,
      SearchField,
      MenuCategories,
    },
    data () {
      return {
        loading: false,
        pageIcon:"icons/menu-w.png",
        menuItems: [{}],
        searchTerm: "",
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