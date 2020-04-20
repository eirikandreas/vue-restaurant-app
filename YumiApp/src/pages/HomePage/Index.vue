<template>
  <div class="home">

    <template v-if="loading">
    
      <AppLoader/>

    </template>

    <template v-else>

      <HomeCarousel/>

      <HomeTopPicksSection
      title="Top Picks"
      link="/menu"
      />

      <HomeCategorySection/>

      <HomeConceptSection
      title="Our Concept"
      text="Lorem ipsum dolor sit amet"
      :showButton="true"
      buttonValue="About us"
      link="/about"
      />

      <ParallaxSection
      :height="500"
      title="Our Concept"
      :showSub="true"
      subheading="This is some shit"
      :icon="parallaxIcon"
      :bgImage="parallaxImage"
      :showButton="true"
      buttonValue="Order now"
      link="/order"
      />
    </template>

  </div>
</template>

<script>
import AppLoader from '@/components/common/AppLoader'
import ParallaxSection from '@/components/ui/ParallaxSection'

import HomeCarousel from '@/pages/HomePage/HomeCarousel.vue'
import HomeCategorySection from '@/pages/HomePage/HomeCategorySection'
import HomeConceptSection from '@/pages/HomePage/HomeConceptSection'
import HomeTopPicksSection from '@/pages/HomePage/HomeTopPicksSection'

export default {
  name: 'Index',
  components: { 
    AppLoader,
    ParallaxSection,
    HomeCarousel,
    HomeCategorySection,
    HomeConceptSection,
    HomeTopPicksSection
  },
  data(){
    return {
      loading: false,
      height: 800,
      hero: { title: "Order, eat & enjoy", btnValue: "Explore our menu", bgImage: "herobg.jpg"},
      parallaxIcon: "icons/takeaway-w.png",
      parallaxImage: "parallax-5.jpg"
    }
  }
}
</script>