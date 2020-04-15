<template>
  <div class="home">

    <template v-if="loading">
    
    <Loader/>

    </template>

    <template v-else>

    <Carousel/>

    <MenuItemsSection
    title="Top Picks"
    link="/menu"/>

    <CategorySection/>

    <ConceptSection
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
import Loader from '@/components/Loader.vue'
import Carousel from '@/pages/HomePage/Carousel.vue'
import CategorySection from '@/pages/HomePage/CategorySection.vue'
import ConceptSection from '@/pages/HomePage/ConceptSection.vue'
import ParallaxSection from '@/components/ParallaxSection.vue'
import MenuItemsSection from '@/pages/HomePage/MenuItemsSection.vue'

export default {
  name: 'Home',
  components: { 
    Loader,
    Carousel,
    CategorySection,
    ConceptSection,
    ParallaxSection,
    MenuItemsSection
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