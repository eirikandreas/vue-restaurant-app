<template>
  <div class="home">

    <template v-if="loading">
    
      <AppLoader/>

    </template>

    <template v-else>

      <HomeTopSection
      :carousel="pageSettings.homeDisplayCarousel"/>

      <template v-if="pageSettings.homeDisplayTopPicks">
        <HomeTopPicksSection
        :title="pageSettings.homeFavTitle"
        link="/menu"
        />
      </template>

      <HomeCategorySection/>

      <HomeConceptSection
      :title="pageSettings.homeTitle"
      :text="pageSettings.homeText"
      :showButton="true"
      buttonValue="About us"
      link="/about"
      />

      <ParallaxSection
      :height="500"
      title="See our menu"
      :showSub="true"
      subheading="If it is for a private celebration or just a little something extra for dinner, we got you covered."
      :icon="parallaxIcon"
      :bgImage="parallaxImage"
      :showButton="true"
      buttonValue="View our Menu"
      link="/menu"
      />

    </template>

  </div>
</template>

<script>
import AppLoader from '@/components/common/AppLoader'
import ParallaxSection from '@/components/ui/ParallaxSection'
import HomeTopSection from '@/pages/HomePage/HomeTopSection.vue'
import HomeCategorySection from '@/pages/HomePage/HomeCategorySection'
import HomeConceptSection from '@/pages/HomePage/HomeConceptSection'
import HomeTopPicksSection from '@/pages/HomePage/HomeTopPicksSection'

export default {
  name: 'Index',
  components: { 
    AppLoader,
    ParallaxSection,
    HomeTopSection,
    HomeCategorySection,
    HomeConceptSection,
    HomeTopPicksSection
  },
  data(){
    return {
      loading: false,
      height: 800,
      hero: { title: "Order, eat & enjoy", btnValue: "Explore our menu", bgImage: "herobg.jpg"},
      parallaxIcon: "takeaway-w.png",
      parallaxImage: "parallax-1.jpg",
      pageSettings: {}
    }
  },
  methods: {
    //Henter ut spesifikk data med id 1 til applikasjonen fra apiet
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
  created(){
    this.getPageSettings()
  }
}
</script>