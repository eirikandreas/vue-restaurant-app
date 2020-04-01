<template>
  <div class="home">
        <Carousel/>
        <!--
    <Hero
    :title="hero.title"
    :btnValue="hero.btnValue"
    :bgImage="hero.imgUrl"
    />

-->


    <CategorySection/>


    <ConceptSection/>

    <ParallaxSection/>




  </div>
</template>

<script>
// @ is an alias to /src
// import Hero from '@/pages/HomePage/Hero.vue'
import Carousel from '@/pages/HomePage/Carousel.vue'
import CategorySection from '@/pages/HomePage/CategorySection.vue'
import ConceptSection from '@/pages/HomePage/ConceptSection.vue'
import ParallaxSection from '@/pages/HomePage/ParallaxSection.vue'

export default {
  name: 'Home',
  components: {
  //  Hero,
    Carousel,
    CategorySection,
    ConceptSection,
    ParallaxSection
  },
  data(){
    return {
      hero: { title: "Order, eat & enjoy", btnValue: "Explore our menu", bgImage: "herobg.jpg"}
    }
  }
}
</script>
