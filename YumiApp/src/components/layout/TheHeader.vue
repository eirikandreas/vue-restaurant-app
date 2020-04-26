<template>
    <v-app-bar app :color="`${bgColor}`" flat dark>


        <div class="d-flex align-center">

            <v-icon class="black--text mr-2">mdi-rice</v-icon>

            <v-toolbar-title class="black--text font-weight-light display-1">{{ title }}</v-toolbar-title>
        
        </div>


        <v-spacer></v-spacer>

<!-- Shopping Cart Menu -->
        <v-badge light top class="black--text" color="red accent-3" overlap offset-x="20" offset-y="20" :content="`${cartItems}`">
            <v-menu offset-y>
                <template v-slot:activator="{ on }"> 
                    <v-btn icon v-on="on">
                        <v-icon class="black--text">mdi-shopping-outline</v-icon>
                    </v-btn>
                </template>

 <v-card>
        <v-list>
          <v-list-item>


            <v-list-item-content>
              <v-list-item-title class="title font-weight-bold">Your shoppingcart</v-list-item-title>
              <v-list-item-subtitle>Items: {{ items.length }}</v-list-item-subtitle>
            </v-list-item-content>

            <v-list-item-action>
                <v-icon>mdi-shopping-outline</v-icon>
            </v-list-item-action>
          </v-list-item>
        </v-list>

    

        <v-list v-for="(item, index) in items"
          :key="index">
                 <v-divider></v-divider>
          <v-list-item>
            <v-list-item-avatar>
              <v-img :src="require(`@/assets/${item.img}`)"></v-img>
            </v-list-item-avatar>
            <v-list-item-content>
            <v-list-item-title>{{ item.title }} </v-list-item-title>
            <v-list-item-subtitle>Quantity <v-btn text small rounded> {{ item.quantity }} <v-icon>mdi-chevron-down</v-icon></v-btn></v-list-item-subtitle>
            <v-list-item-subtitle>Price {{ item.price }}</v-list-item-subtitle>
            </v-list-item-content>
          
            <v-btn icon>
            <v-icon small>mdi-close</v-icon>
            </v-btn>
            
          </v-list-item>
   
        </v-list>

          <v-list>
               <v-divider></v-divider>

     <v-list-item>    
            <v-list-item-content>
              <v-list-item-title class="title font-weight-bold">Total:</v-list-item-title>
            </v-list-item-content>

                 <v-list-item-action>
              <v-list-item-title class="title font-weight-bold">$16</v-list-item-title>
            </v-list-item-action>

     </v-list-item>
        </v-list>

        <v-card-actions>
          <v-spacer></v-spacer>

          <v-btn rounded depressed block color="amber accent-3" @click="menu = false">Order</v-btn>
        </v-card-actions>
      </v-card>
            
            </v-menu>
        </v-badge>
<!-- end Shopping Cart Menu -->

        <template v-if="isLoggedIn">

            <v-btn icon>
                <v-icon class="black--text">mdi-account-outline</v-icon>
            </v-btn>

        </template>

        <template v-else>

            <v-btn to="/Register" rounded color="amber accent-3 black--text" class="ml-4" dark min-width="150px" depressed>Registrer deg</v-btn>
            <v-btn to="/Login" rounded color="amber accent-3 black--text" class="ml-4" dark min-width="150px" depressed>Logg in</v-btn>
        
        </template>


        <template v-if="isAdmin">

            <v-btn icon>
                <v-icon class="black--text">mdi-cogs</v-icon>
            </v-btn>

        </template>

    </v-app-bar>
</template>

<script>

export default {
    name: 'TheHeader',
    
    props: {
        title: { type: String, default: "App" },
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
        }
    },

}
</script>