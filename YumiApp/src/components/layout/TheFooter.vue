<template>
  <v-footer
  dark
  padless
  class="black white--text"
  >

  <v-container>
    <v-row>
        <v-col cols="12">
          <v-card-text class="text-center">
            <v-btn
              v-for="(someLink, index) in someLinks"
              :key="index"
              class="mx-4 white--text"
              icon
              :to="someLink.link"
            >
            <v-icon size="24px">{{ someLink.icon }}</v-icon>
            </v-btn>
          </v-card-text>
        </v-col>
    </v-row>

    <v-row>
      <v-col cols="12" sm="6" md="4">
        <v-card color="transparent">
          <v-card-title>Sitemap</v-card-title>
            <v-list color="transparent" dense>
              <v-list-item
              v-for="(link, i) in links"
              :key="i"
              >
                <v-list-item-content>
                  <v-list-item-title><v-btn text :to="`${link.to}`">{{link.title}}</v-btn></v-list-item-title>
                </v-list-item-content>
              </v-list-item>
            </v-list>
        </v-card>
      </v-col>

      <v-col cols="12" sm="6" md="4"> 
        <v-card color="transparent">
          <v-card-title>About</v-card-title>
            <v-card-text class="white--text pt-0">
            Phasellus feugiat arcu sapien, et iaculis ipsum elementum sit amet. Mauris cursus commodo interdum.
            </v-card-text>
        </v-card>
      </v-col>

      <v-col cols="12" sm="12" md="4"> 
        <v-card color="transparent">
          <v-card-title>Contact</v-card-title>
          <v-card-text class="white--text pt-0">
          Phasellus feugiat arcu sapien, et iaculis ipsum elementum sit amet. Mauris cursus commodo interdum.
          </v-card-text>
        </v-card>
      </v-col>

    </v-row>
  </v-container>

  <v-container fluid class="pa-0">
    <v-row class="no-gutters">
      <v-col cols="12" md="12">
        <v-card class="text-center" color="red">
          <v-card-text>
          {{ new Date().getFullYear() }} — <strong>{{appName}}</strong>
          </v-card-text>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
 
  </v-footer>
</template>

<script>
export default {
    name: 'TheFooter',
    props: {
      appName: { type: String, default: "App"}
    },
    data() {
        return {
          transparent: 'rgba(0, 0, 0, 0)',
           someLinks: [
        { icon: "mdi-facebook", link:"#" },
        { icon: "mdi-twitter", link:"#" },
        { icon: "mdi-instagram", link:"#" },
      ],
      links: [
        { title: 'Home', to: '/' },
        { title: 'Menu', to: '/menu'},
        { title: 'About', to: '/about' },
        { title: 'Contact', to: '/contact' },
        { title: 'Order Online', to: '/orderonline' },
      ]
        }
    },

}
</script>
