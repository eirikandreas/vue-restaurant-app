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
      { title: "Something", text: "Something more"},
      { title: "Something", text: "Something more"},
      { title: "Something", text: "Something more"},

    ]
  }),
};
</script>
