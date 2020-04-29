<template>
  <div class="contact">
    <template v-if="loading">
      <AppLoader/>
    </template>

    <template v-else>

      <ParallaxSection
      :title="pageSettings.contactHeaderTitle"
      />

      <div class="pt-10 pb-10">
        <ContactSection
        :cardTitle="pageSettings.contactTitle"
        :cardText="pageSettings.contactText"
        />
      </div>

      <ParallaxSection
      :height="500"
      :title="parallax.title"
      :showSub="true"
      :subheading="parallax.subtitle"
      :showButton="true"
      :buttonValue="parallax.btnValue"
      :link="parallax.link"
      />

      <ServicesList/>

    </template>
  </div>
</template>

<script>
import AppLoader from '@/components/common/AppLoader'
import ContactSection from '@/pages/ContactPage/ContactSection.vue'
import ParallaxSection from '@/components/ui/ParallaxSection.vue'
import ServicesList from '@/pages/ContactPage/ServicesList.vue'

export default {
  name: 'Contact',
  components: {
    AppLoader,
    ContactSection,
    ParallaxSection,
    ServicesList
  },
  data(){
    return {
      loading: false,
      pageSettings: {},
      abouthero: { title: "Contact us", bgImage: "sushi.jpg"},
      conceptsectioncontact: { cardTitle: "What can we do for you?", cardText: "Contact us and become our regular customer"},
        parallax: {
          title: "Who are we?",
          subtitle: "Get to know our story",
          btnValue: "About us",
          link: "/about"
        }
    }
  },
  methods: {
    /*
    Henter ut spesifikk data med id 1 til applikasjonen fra apiet 
    og legger dataen i pageSettings objektet
    */
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
