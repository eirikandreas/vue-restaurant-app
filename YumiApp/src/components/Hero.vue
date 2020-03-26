<template>
    <v-img :src="require(`@/assets/${bgImage}`)" width="100vw" height="100vh">

        <v-container class="fill-height">

            <v-card flat color="transparent" width="50%">
                <h1 class="display-4 font-weight-black">{{title}}</h1>
    
                <v-btn rounded large color="amber accent-3 black--text" class="mt-5" dark min-width="150px" depressed>{{btnValue}}</v-btn>
    
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