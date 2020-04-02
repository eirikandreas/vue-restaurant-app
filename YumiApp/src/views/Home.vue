<template>
  <div class="home">
    <Hero
    :title="hero.title"
    :btnValue="hero.btnValue"
    :bgImage="hero.imgUrl"
    />
    
  </div>
</template>

<script>
// @ is an alias to /src
import Hero from '@/components/Hero.vue'

export default {
  name: 'Home',
  components: {
    Hero
  },
  data(){
    return {
      hero: { title: "Order, eat & enjoy", btnValue: "Explore our menu", bgImage: "herobg.jpg"}
    }
  }
}
</script>
