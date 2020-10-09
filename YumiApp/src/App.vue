<template>
  <v-app>

    <TheHeader 
    :appName="pageTitle"
    :links="links"
    />

    <v-content>
      <router-view/>
    </v-content>

    <TheFooter
    :appName="pageTitle"
    :footerItems="footerItems"
    :links="links"
    :someLinks="someLinks"
    />

  </v-app>
</template>

<script>
import TheHeader from '@/components/layout/TheHeader';
import TheFooter from '@/components/layout/TheFooter';

export default {
  name: 'App',
  components: {
    TheHeader,
    TheFooter
  },
  data: () => ({
    pageTitle: "YUMI",
    links: [
      { title: 'Home', to: '/' },
      { title: 'Menu', to: '/menu'},
      { title: 'About', to: '/about' },
      { title: 'Contact', to: '/contact' },
    ],
    someLinks: [
      { icon: "mdi-facebook", link:"#" },
      { icon: "mdi-twitter", link:"#" },
      { icon: "mdi-instagram", link:"#" },
    ],
    footerItems: [
      { title: "About", text: "Yumi is a big, locally owned sushi resturant in Oslo. Since 1999, Yumi has been producing high quality Asian dishes. Visit us for a great taste experience."},
      { title: "Get in touch", text: "Reach us by mail or phone. +47 22453590 yumioslo@sushi.com"},
      { title: "Location", text: "Cort Adelers gate 2, 0254 Oslo"},

    ]
  }),
};
</script>
