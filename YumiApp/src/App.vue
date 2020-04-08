<template>
  <v-app>

    <TheHeader 
    :title="pageContent.pageTitle"
    :cartItems="header.cartItems"
    :isLoggedIn="header.isLoggedIn"
    :isAdmin="header.isAdmin"
    :bgColor="header.bgColor"
    />
      <v-content>
        <router-view/>
      </v-content>
    <TheFooter/>

  </v-app>
</template>

<script>
import TheHeader from './components/layout/TheHeader';
import TheFooter from './components/layout/TheFooter';

export default {
  name: 'App',
  components: {
    TheHeader,
    TheFooter
  },
  data: () => ({
    isAdmin: true,
    header: { title: "YUMI", bgColor: "black", cartItems: 3, isLoggedIn: false, isAdmin: false},
    pageContent: {},
  }),
    methods: {
        getPageContent(){
          let webAPIUrl = "https://localhost:5001/pagecontent/1";
          this.$http.get( webAPIUrl )
            .then( result => {
              this.pageContent = result.data;
              console.log(this.pageContent)
            })
        }
    },
    created(){
      this.getPageContent()
    }
};
</script>
<style>
.mt-n-header {
  margin-top: -64px;
}
</style>
