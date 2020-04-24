<template>
<section class="mt-12 mb-12"  id="ResturantList-section">
<v-col>
    <v-row>
<v-card
    class="mx-auto"
    max-width="400"
  >
    <v-img
      class="amber--text align-end"
      height="200px"
      src="https://storage.googleapis.com/snl-no-media/media/132105/article_topimage_Oslo1.jpg"
    >
      <v-card-title><h1>{{cardTitle1}}</h1></v-card-title>
    </v-img>

    <v-card-text class="text--primary">
      <div><h3>{{heading1}}</h3>{{card1Description1}}</div>

      <div><h3>{{heading2}}</h3>{{card1Description2}}</div>
    </v-card-text>

    </v-card>
    <v-card
    class="mx-auto"
    max-width="400"
  >
    <v-img
      class="amber--text align-end"
      height="200px"
      src="https://media.radissonhotels.net/image/Radisson-Blu-Royal-Hotel-Bergen/Exteriorview/16256-113899-f62715764_3XL.jpg?impolicy=HomeHero"
    >
      <v-card-title><h1>{{cardTitle2}}</h1></v-card-title>
    </v-img>

    <v-card-text class="text--primary">
     <div><h3>{{heading1}}</h3>{{card2Description1}}</div>

      <div><h3>{{heading2}}</h3>{{card2Description2}}</div>
    </v-card-text>

</v-card>
    <v-card
    class="mx-auto"
    max-width="400"
  >
    <v-img
      class="amber--text align-end"
      height="200px"
      src="https://www.dips.com/sites/default/files/styles/article_main/public/shutterstock_1186327096.jpg?itok=ZJoGtU9H"
    >
      <v-card-title><h1>{{cardTitle3}}</h1></v-card-title>
    </v-img>

    <v-card-text class="text--primary">
      <div><h3>{{heading1}}</h3>{{card3Description1}}</div>

      <div><h3>{{heading2}}</h3>{{card3Description2}}</div>
    </v-card-text>

    </v-card>

    
  </v-row>
  </v-col>
</section>
</template>

<script>

export default {
    name: 'ResurantListSection',
    props: {

        cardTitle1: { type: String, default: "Yummi Oslo" },
        cardTitle2: { type: String, default: "Yummi Bergen" },
        cardTitle3: { type: String, default: "Yummi Trondheim" },
        heading1: { type: String, default: "Address:" },
        heading2: { type: String, default: "Phonenumber:" },
        card1Description1: { type: String, default: "Karl Johans Gate 1, 0170" },
        card1Description2: { type: String, default: "+47 123 45 678" },
        card2Description1: { type: String, default: "Hordalandsgaten 1, 5051 Bergen" },
        card2Description2: { type: String, default: "+47 123 45 678" },
        card3Description1: { type: String, default: "Trondheimsgata 1, 7018 Trondheim" },
        card3Description2: { type: String, default: "+47 123 45 678" },


       
    },
  } 
</script>
<style scoped>
.hero-font-size-sm {
    font-size: 5rem;
    line-height: 4.5rem;
}

.hero-font-size-md {
    font-size: 6rem;
    line-height: 5rem;
}

.hero-card-width {
    width: 60%;
}
</style>