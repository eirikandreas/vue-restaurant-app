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
        <v-col cols="12" sm="4" v-for="(item, index) in footerItems" :key="index">

          <FooterItem
          :title="item.title"
          :text="item.text"
          />

        </v-col>
      </v-row>
    </v-container>

    <v-container class="pa-0 hidden-sm-and-down">
      <v-divider></v-divider>
      <v-row class="no-gutters">
        <v-col cols="12" class="pb-5 pt-5">
          <NavigationLinks
            :links="links"/>
        </v-col>
      </v-row>
    </v-container>
   
    <v-container fluid class="pa-0">
      <v-row class="no-gutters">
        <v-col cols="12" md="12">
          <v-card flat tile class="text-center" color="red">
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
import NavigationLinks from '@/components/ui/NavigationLinks'
import FooterItem from '@/components/ui/FooterItem'

export default {
    name: 'TheFooter',
    props: {
      appName: { type: String, default: "App"},
      footerItems: { type: Array },
      links: { type: Array },
      someLinks: { type: Array }
    },
    components: {
      NavigationLinks,
      FooterItem
    },
}
</script>
