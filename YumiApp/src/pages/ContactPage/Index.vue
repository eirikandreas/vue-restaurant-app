<template>
  <div class="contact">

    <AboutHero
    :title="abouthero.title"
    :bgImage="abouthero.bgImage"/>

    <ConceptSectionContact
    :cardTitle="conceptsectioncontact.cardTitle"
    :cardText="conceptsectioncontact.cardText"
    />

    <ResturantSection
    :cardTitle1="resturantsection.cardTitle1"
    :cardTitle2="resturantsection.cardTitle2" 
    :cardTitle3="resturantsection.cardTitle3"
    :heading1="resturantsection.heading1"
    :heading2="resturantsection.heading2"
    :card1Description1="resturantsection.card1Description1"
    :card1Description2="resturantsection.card1Description2"
    :card2Description1="resturantsection.card2Description1"
    :card2Description2="resturantsection.card2Description2"
    :card3Description1="resturantsection.card3Description1"
    :card3Description2="resturantsection.card3Description2"
    />

    <ParallaxSection/>

    <ServicesContact/>



    

    




  </div>
</template>

<script>

import AboutHero from '@/pages/AboutPage/AboutHero.vue'
import ConceptSectionContact from '@/pages/ContactPage/ConceptSectionContact.vue'
import ParallaxSection from '@/components/ui/ParallaxSection.vue'
import ResturantSection from '@/pages/ContactPage/ResturantSection.vue'
import ServicesContact from '@/pages/ContactPage/ServicesContact.vue'

export default {
  name: 'Contact',
  components: {
    AboutHero,
    ConceptSectionContact,
    ParallaxSection,
    ResturantSection,
    ServicesContact
  },
  data(){
    return {
      abouthero: { title: "Contact us", bgImage: "sushi.jpg"},
      conceptsectioncontact: { cardTitle: "What can we do for you?", cardText: "Contact us and become our regular customer"},
      resturantsection: { cardTitle1: "Yummi Oslo", cardTitle2: "Yummi Bergen", cardTitle3: "Yummi Trondheim", heading1:"Address:", heading2: "Phonenumber:", card1Description1:"Karl Johans Gate 1, 0170 Oslo", card1Description2:"+47 123 45 678", card2Description1:"Hordalandsgaten 1, 5051 Bergen", card2Description2:"+47 123 45 678", card3Description1:"Trondheimsgata 1, 7018 Trondheim", card3Description2:"+47 123 45 678",   }
    }
  }
}
</script>
