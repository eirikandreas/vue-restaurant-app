<template>
  <div>
    <template v-if="loading">
    
      <AppLoader/>

    </template>

    <template v-else>

      <ParallaxSection
      :title="pageSettings.menuHeaderTitle"
      :icon="pageIcon"/>

      <section class="search">
        <v-sheet tile color="red">
          <v-container>
            <SearchField/>
         </v-container>
        </v-sheet>
      </section>

      <MenuCategories/>

      <v-container>
        <router-view/> 
      </v-container>

    </template>

  </div>     
</template>
<script>
import AppLoader from '@/components/common/AppLoader'
import ParallaxSection from '@/components/ui/ParallaxSection'
import SearchField from '@/components/ui/SearchField'
import MenuCategories from '@/components/menu/MenuCategories'

export default {
    name: 'Index',
    components: {
      AppLoader,
      ParallaxSection,
      SearchField,
      MenuCategories,
    },
    data () {
      return {
        loading: false,
        pageSettings: {},
        pageIcon:"menu-w.png",
        menuItems: [{}],
      }
    },
    methods: {
      getPageSettings(){
        this.loading = true;
        let webAPIUrl = "https://localhost:5001/user/pagesettings/1";
        this.$http.get( webAPIUrl )
          .then( response => { 
            this.pageSettings = response.data;
            this.loading = false
            })   
        },
    },
    created() {
      this.getPageSettings()
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