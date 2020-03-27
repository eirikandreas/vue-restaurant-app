<template>
    <v-img :src="require(`@/assets/${bgImage}`)" width="100vw" height="100vh">

        <v-container class="fill-height">

            <v-card flat color="transparent" :class="{ 'hero-card-width': $vuetify.breakpoint.smAndUp}">
                <h1 :class="{'hero-font-size-sm font-weight-bold': $vuetify.breakpoint.smAndDown, 'hero-font-size-md font-weight-bold': $vuetify.breakpoint.smAndUp}">{{title}}</h1>
    
                <v-btn rounded large color="amber accent-3 black--text" class="mt-10" dark min-width="150px" depressed>{{btnValue}}</v-btn>
    
            </v-card>

            <v-spacer></v-spacer>

        </v-container>
    
    </v-img>
</template>

<script>
export default {
    name: 'Hero',
    props: {
        title: { type: String, default: "App" },
        btnValue: { type: String, default: "Click" },
        bgImage: { type: String, default: "herobg.jpg" },
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
    line-height: 5rem;
}

.hero-card-width {
    width: 60%;
}
</style>