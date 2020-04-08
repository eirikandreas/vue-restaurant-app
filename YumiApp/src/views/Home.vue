<template>
  <div class="home">

    <Carousel/>
    <MenuItemsSection/>
    <CategorySection/>
    <ConceptSection/>
    <ParallaxSection/>

  </div>
</template>

<script>
import Carousel from '@/pages/HomePage/Carousel.vue'
import CategorySection from '@/pages/HomePage/CategorySection.vue'
import ConceptSection from '@/pages/HomePage/ConceptSection.vue'
import ParallaxSection from '@/pages/HomePage/ParallaxSection.vue'
import MenuItemsSection from '@/pages/HomePage/MenuItemsSection.vue'

export default {
  name: 'Home',
  components: { 
    Carousel,
    CategorySection,
    ConceptSection,
    ParallaxSection,
    MenuItemsSection
  },
  data(){
    return {
      hero: { title: "Order, eat & enjoy", btnValue: "Explore our menu", bgImage: "herobg.jpg"}
    }
  }
}
</script>
