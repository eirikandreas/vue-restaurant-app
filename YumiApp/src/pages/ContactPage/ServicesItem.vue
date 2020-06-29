<template>

<v-col class="text-center"  cols="12" sm="12" md="4">
    <v-card flat tile class="d-flex flex-column align-center">
        <v-img class="align-center justify-center" :src="require(`@/assets/icons/${servicesIcon}`)" width="50" height="50"></v-img>
            
            <v-card-title class="red--text font-weight-bold">{{heading}}</v-card-title>
            <v-card-text class="grey--text">{{info}}</v-card-text>

    </v-card>
</v-col>

</template>


<script>
export default {
    name: "ServicesItem",
    props:{
        servicesIcon: String,
        heading: String,
        info: String
    }    
}
</script>

