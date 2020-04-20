<template>
    <v-img :src="require(`@/assets/${bgImage}`)" width="100vw" height="100vh">

        <v-container class="fill-height">

            <v-card flat color="transparent" :class="{ 'hero-card-width': $vuetify.breakpoint.smAndUp}">
                <h1 :class="{'hero-font-size-sm font-weight-bold white--text': $vuetify.breakpoint.xsOnly, 'hero-font-size-md font-weight-bold': $vuetify.breakpoint.smAndUp}">{{title}}</h1>
                <v-btn rounded large color="amber accent-3 black--text" class="mt-10" dark min-width="150px" depressed :to="`${link}`">{{btnValue}}</v-btn>  
            </v-card>

        </v-container>
    
    </v-img>
</template>

<script>
export default {
    name: 'HomeHero',
    props: {
        title: { type: String, default: "App" },
        btnValue: { type: String, default: "Click" },
        bgImage: { type: String, default: "herobg.jpg" },
        link: { type: String, default: "#"}
    },
    data() {
        return {
        }
    }
}
</script>
<style scoped>
.hero-font-size-sm {
    font-size: 5rem;
    line-height: 4.5rem;
}

.hero-font-size-md {
    font-size: 6rem;
    line-height: 6.2rem;
}

.hero-card-width {
    width: 60%;
}

.overlay-gradient {
    height: 600px;
    background: -moz-linear-gradient(bottom, rgba(0,0,0,0.65) 0%, rgba(0,0,0,0) 100%); /* FF3.6-15 */
    background: -webkit-linear-gradient(bottom, rgba(0,0,0,0.65) 0%,rgba(0,0,0,0) 100%); /* Chrome10-25,Safari5.1-6 */
    background: linear-gradient(to top, rgba(0,0,0,0.65) 0%,rgba(0,0,0,0) 100%); /* W3C, IE10+, FF16+, Chrome26+, Opera12+, Safari7+ */
}
</style>