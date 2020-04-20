<template>
    <v-app-bar app dark :color="`${bgColor}`" flat>
        <div class="d-flex align-center">
            <v-icon class="mr-2">mdi-rice</v-icon>
            <v-toolbar-title class="font-weight-light display-1">{{ title }}</v-toolbar-title>
        </div>

        <v-spacer></v-spacer>

        <div class="hidden-sm-and-down mx-auto" v-for="(link, index) in links" :key="index">
        <v-btn text :to="`${link.to}`">{{ link.title }} </v-btn>
        </div>

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

      <!-- Mobile Menu -->
      <v-menu min-width="100%" height="100vh" flat tile nudge-top offset-y>
        <template v-slot:activator="{ on }">
          <v-btn
          dark
          icon
          v-on="on"
          close-on-click
          close-on-content-click
          class="hidden-md-and-up"
          >
            <v-icon>mdi-menu</v-icon>
          </v-btn>
        </template>

        <v-card>
          <v-list>
            <v-list-item
            v-for="(link, i) in links"
            :key="i"
            >
              <v-list-item-title><v-btn text :to="link.to">{{ link.title }}</v-btn></v-list-item-title>
            </v-list-item>
            <v-list-item>
              <v-btn rounded color="amber accent-3 black--text" block dark min-width="150px" depressed>Log in</v-btn>
            </v-list-item>
          </v-list>
        </v-card>
      </v-menu>
      <!-- Mobile menu end -->

    </v-app-bar>
</template>

<script>
import ShoppingCart from '@/components/ui/ShoppingCart'
export default {
    name: 'TheHeader',
    components: {
      ShoppingCart
    },
    props: {
        title: { type: String, default: "" },
        bgColor: { type: String, default: "transparent"},
        cartItems: { type: Number, default: 0},
        isLoggedIn: { type: Boolean, default: false },
        isAdmin: { type: Boolean, default: false },
    },
    data() {
        return {
            items: [
        { title: 'Salmon Nigiri', price: 6, quantity: "8", img: "1.jpg" },
        { title: 'Scallop Nigiri', price: 6, quantity: "12", img: "2.jpg"  },
        { title: 'Crab Maki', price: 4,  quantity: "12",img: "3.jpg" },
      ],
      links: [
        { title: 'Home', to: '/' },
        { title: 'Menu', to: '/menu'},
        { title: 'About', to: '/about' },
        { title: 'Contact', to: '/contact' },
      ],
    
        }
    }

}
</script>