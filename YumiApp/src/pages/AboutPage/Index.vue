<template>
  <div class="about">

      <template v-if="loading">
        <AppLoader/>
      </template>

      <template v-else>

      <ParallaxSection
      :title="pageSettings.aboutHeaderTitle"/>
    
      <div class="pt-10 pb-10">
        <InfoSection
        :twotext="true"
        :title="pageSettings.aboutTitle"
        :image="aboutinfo.imgSrc"
        :text="pageSettings.aboutText1"
        :text2="pageSettings.aboutText2"
        
        />
      </div>

      <ParallaxSection
      :height="500"
      :title="resturantsection.title"
      :showSub="true"
      :subheading="resturantsection.text"
      :icon="resturantsection.resturantSectionIcon"
      :bgImage="resturantsection.resturantSectionImg"
      :showButton="true"
      :buttonValue="resturantsection.btnValue"
      link="/contact"/>

      <AboutTeamList/>
    </template>
  </div>
</template>

<script>
import AppLoader from '@/components/common/AppLoader'
import InfoSection from '@/components/ui/InfoSection'
import AboutTeamList from '@/pages/AboutPage/AboutTeamList.vue'
import ParallaxSection from '@/components/ui/ParallaxSection.vue'

export default {
  name: 'About',
  components: {
    AppLoader,
    InfoSection,
    AboutTeamList,
    ParallaxSection
  },
  data(){
    return {
      loading: false,
      pageSettings: {},
      abouthero: { title: "About Us", bgImage: "herobg.jpg"},
      aboutinfo: { 
        imgSrc: "chef.jpg", 
        heading: "Who we are", 
        info: "Yumi is a big, locally owned and operated bakery in Oslo, Bergen and Trondheim.Since 1999, Yumi has been producing its high quality product on the popular. Partners Hilma Maier and Robert McMonigle felt that Burlingame was the perfect location to continue their centuries old trade. We believe that a healthy lifestyle begins with a healthy dietOur focus is to provide Yumi desserts and snacks that are nutritious and delicious. Our products always feature as many local, organic ingredients as possible.",
        heading2: "Why choose us", 
        info2: "We are proud to be featuring thet following local ingredients in our bakery.All of our bakery items are made with all-natural ingredients and contain no artificial preservatives, so we recommend that you freeze or refrigerate these baked goods in order to extend the shelf life. We dedicated to helping you stay healthy while still.Hopefully we success story will help encourage you on the path to a new, healthy you!"
      },
      resturantsection: { 
        resturantSectionIcon: "bowl-w.png",
        resturantSectionImg: "resturant.jpg", 
        title: "Visit Us", 
        btnValue: "Contact Us", 
        text: "Restaurant is proud to be serving fine Asian dishes for more than 20 years!" 
      },
           
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
  created() {
    this.getPageSettings()
  }
}
</script>
