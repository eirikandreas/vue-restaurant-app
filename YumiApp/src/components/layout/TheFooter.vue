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
          v-for="icon in icons"
          :key="icon"
          class="mx-4 white--text"
          icon
        >
          <v-icon size="24px">{{ icon }}</v-icon>
        </v-btn>
      </v-card-text>
    </v-col>
</v-row>


<v-row>

    <v-col cols="12" sm="6" md="4">
<v-card color="transparent">
         <v-card-title>Links</v-card-title>
            <v-list color="transparent">
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
         <v-card-title>Contact</v-card-title>
      <v-card-text class="white--text pt-0">
        Phasellus feugiat arcu sapien, et iaculis ipsum elementum sit amet. Mauris cursus commodo interdum. Praesent ut risus eget metus luctus accumsan id ultrices nunc. Sed at orci sed massa consectetur dignissim a sit amet dui. Duis commodo vitae velit et faucibus. Morbi vehicula lacinia malesuada. Nulla placerat augue vel ipsum ultrices, cursus iaculis dui sollicitudin. Vestibulum eu ipsum vel diam elementum tempor vel ut orci. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.
      </v-card-text>

     </v-card>
    </v-col>



    <v-col cols="12" sm="12" md="4"> 

        <v-card color="transparent">

             <v-card-title>About</v-card-title>
      <v-card-text class="white--text pt-0">
        Phasellus feugiat arcu sapien, et iaculis ipsum elementum sit amet. Mauris cursus commodo interdum. Praesent ut risus eget metus luctus accumsan id ultrices nunc. Sed at orci sed massa consectetur dignissim a sit amet dui. Duis commodo vitae velit et faucibus. Morbi vehicula lacinia malesuada. Nulla placerat augue vel ipsum ultrices, cursus iaculis dui sollicitudin. Vestibulum eu ipsum vel diam elementum tempor vel ut orci. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.
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

        {{ new Date().getFullYear() }} — <strong>Yumi</strong>

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
        title: { type: String, default: "App" },
        bgColor: { type: String, default: "transparent"},
        cartItems: { type: Number, default: 0},
        isLoggedIn: { type: Boolean, default: false },
        isAdmin: { type: Boolean, default: false },
    },
    data() {
        return {
          transparent: 'rgba(0, 0, 0, 0)',
           icons: [
        'mdi-facebook',
        'mdi-twitter',
        'mdi-instagram',
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
<style>
.footerBg {
    background-color: #ff00cc;
}
</style>