<template>
<div>
   <v-hover v-slot:default="{ hover }">
     <v-card flat class="white--text">
      
<v-img :src="`https:/localhost:5001/images/${image}`" height="300px">
<div class="overlay-gradient d-flex flex-column justify-end">

    <v-card-title class="headline">{{title}}</v-card-title>
     <v-card-subtitle class="white--text">{{category}}</v-card-subtitle>

<v-expand-transition>

    <div v-if="hover" class="d-flex transition-fast-in-slow-out">


   <v-card-text>
        
  <v-btn rounded depressed color="amber accent-3 mr-3">View</v-btn>
<v-btn rounded depressed color="amber accent-3">Order</v-btn>      
   </v-card-text>
        </div>
   

</v-expand-transition>

</div>

</v-img>
    
     </v-card>
      </v-hover>
</div>
</template>
<script>
export default {
    props: {
        title: { type: String, default: "Not set" },
        category: { type: String, default: "Not set" },
        image: { type: String, default: "default.jpg" },
        btnRoute: { type: String, default: "default.jpg" },
    },
    name: 'MenuItem',
    data(){
        return {
        webAPIUrl: "https://localhost:5001/images/"
        }
    }
    
}
</script>

<style scoped>

.v-card--reveal {

}
.ovl {
    background-color: red;
    
}

.overlay-gradient {
height: 300px;
background: -moz-linear-gradient(bottom, rgba(0,0,0,0.65) 0%, rgba(0,0,0,0) 100%); /* FF3.6-15 */
background: -webkit-linear-gradient(bottom, rgba(0,0,0,0.65) 0%,rgba(0,0,0,0) 100%); /* Chrome10-25,Safari5.1-6 */
background: linear-gradient(to top, rgba(0,0,0,0.65) 0%,rgba(0,0,0,0) 100%); /* W3C, IE10+, FF16+, Chrome26+, Opera12+, Safari7+ */
}
</style>