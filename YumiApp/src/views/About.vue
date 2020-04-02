<template>
  <div class="about">
    <AboutHero
    :title="abouthero.title"
    :bgImage="abouthero.imgUrl"
    />

    <AboutInfo/>

    

    <!--
    <TheHeader 
    :title="header.title"
    :cartItems="header.cartItems"
    :isLoggedIn="header.isLoggedIn"
    :isAdmin="header.isAdmin"
    :bgColor="header.bgColor"
    /> -->
    


   

  </div>

</template>

<script>
// @ is an alias to /src
import AboutHero from '@/pages/aboutPage/AboutHero'
import AboutInfo from '@/pages/aboutPage/AboutInfo'
//import TheHeader from '@/components/layout/TheHeader';

export default {
  name: 'About',

  components: {
   // TheHeader
   AboutHero,
   AboutInfo
  },
  data(){
    return {
      abouthero: { title: "About Us", bgImage: "herobg.jpg"}
    }
  }

}
</script>



<style>
.mt-n-header {
  margin-top: -64px;
}
</style>

