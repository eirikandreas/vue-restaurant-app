<template>

<v-col class="text-center  d-flex flex-column align-center"  cols="12" sm="12" md="3">
    <v-container class="mt-12 mb-12">
        

            <div align="center">
                 <v-img class="align-center justify-center" :src="require(`@/assets/icons/${servicesIcon}`)" width="50" height="50"></v-img>
            </div>
                 <h3 class="red--text"  >{{heading}}</h3>
                 <p class="grey--text">{{info}}</p>

    </v-container>
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

