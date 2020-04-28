<template>
    <v-app-bar app dark color="black" flat>
      <div class="d-flex align-center">
          <router-link to="/" class="logo d-flex">
            <v-icon class="mr-2">mdi-rice</v-icon>
            <v-toolbar-title class="font-weight-light display-1">{{ appName }}</v-toolbar-title>
          </router-link>
      </div>

      <v-spacer></v-spacer>

      <NavigationLinks
      :links="links"/>

      <v-spacer></v-spacer>

      <!-- Shopping Cart Menu -->
      <ShoppingCart/>
      <!-- end Shopping Cart Menu -->

      <v-tooltip bottom>
        <template v-slot:activator="{ on }">
          <v-btn icon :to="`/admin`" v-on="on">
            <v-icon class="white--text">mdi-cogs</v-icon>
          </v-btn>
        </template>
        <span>View Admin Page</span>
      </v-tooltip>

      <MobileHeaderMenu
      :links="links"
      />

    </v-app-bar>
</template>

<script>
import NavigationLinks from '@/components/ui/NavigationLinks'
import ShoppingCart from '@/components/ui/ShoppingCart'
import MobileHeaderMenu from '@/components/ui/MobileHeaderMenu'
export default {
    name: 'TheHeader',
    components: {
      NavigationLinks,
      ShoppingCart,
      MobileHeaderMenu
    },
    props: {
        appName: { type: String, default: "" },
        links: {type: Array }
    },

}
</script>
<style scoped>
.logo {
  text-decoration: none;
  color: #ffffff;
  transition: ease .5s;
}

.logo:hover {
  color: #ffc400;
}
</style>