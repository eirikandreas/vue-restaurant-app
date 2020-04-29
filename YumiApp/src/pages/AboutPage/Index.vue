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
        :image="aboutImage"
        :text="pageSettings.aboutText1"
        :text2="pageSettings.aboutText2"
        />
      </div>

      <ParallaxSection
      :height="500"
      :title="parallaxSection.title"
      :showSub="true"
      :subheading="parallaxSection.text"
      :icon="parallaxSection.icon"
      :bgImage="parallaxSection.image"
      :showButton="true"
      :buttonValue="parallaxSection.btnValue"
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
      aboutImage: "about-image.jpg",
      parallaxSection: { 
        icon: "bowl-w.png",
        image: "parallax-2.jpg", 
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
