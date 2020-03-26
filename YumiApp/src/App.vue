<template>
  <v-app>
    <TheHeader 
    :title="header.title"
    :cartItems="header.cartItems"
    :isLoggedIn="header.isLoggedIn"
    :isAdmin="header.isAdmin"
    :bgColor="header.bgColor"
    />

    <v-content>
      <router-view
      absolute top
      class="mt-n-header"
      />
    </v-content>
  </v-app>
</template>

<script>
import TheHeader from './components/layout/TheHeader';

export default {
  name: 'App',

  components: {
    TheHeader
  },

  data: () => ({
    header: { title: "YUMI", bgColor: "transparent", cartItems: 3, isLoggedIn: false, isAdmin: false}
    //
  }),
  
};
</script>
<style>
.mt-n-header {
  margin-top: -64px;
}
</style>
