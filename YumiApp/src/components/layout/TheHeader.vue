<template>
    <v-app-bar app :color="`${bgColor}`" flat dark>


        <div class="d-flex align-center">

            <v-icon class="black--text mr-2">mdi-rice</v-icon>

            <v-toolbar-title class="black--text font-weight-light display-1">{{ title }}</v-toolbar-title>
        
        </div>


        <v-spacer></v-spacer>


        <v-badge light top class="black--text" color="red accent-3" overlap offset-x="20" offset-y="20" :content="`${cartItems}`">

            <v-btn icon>
                <v-icon class="black--text">mdi-cart-outline</v-icon>
            </v-btn>

        </v-badge>


        <template v-if="isLoggedIn">

            <v-btn icon>
                <v-icon class="black--text">mdi-account-outline</v-icon>
            </v-btn>

        </template>

        <template v-else>

            <v-btn rounded color="amber accent-3 black--text" class="ml-4" dark min-width="150px" depressed>Log in</v-btn>
        
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

        }
    },

}
</script>