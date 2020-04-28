<template>  
    <v-container class="mt-12 mb-12" >
        <v-row
        align="center"
        justify="center"
       >
            <v-col class="text-center  d-flex flex-column align-center"  cols="12" sm="12" md="3">
                 <v-img class="align-center" :src="require(`@/assets/icons/${servicesIcon1}`)" width="50" height="50"></v-img>
                <h3 class="red--text"  >{{heading1}}</h3>
                 <p class="grey--text">{{info1}}</p>

            </v-col>

            <v-col class="text-center  d-flex flex-column align-center" cols="12" sm="12" md="3">
                 <v-img class="align-center" :src="require(`@/assets/icons/${servicesIcon2}`)" width="50" height="50"></v-img>
                <h3 class="red--text">{{heading2}}</h3>
                 <p class="grey--text">{{info2}}</p>
                
            </v-col>

            <v-col class="text-center  d-flex flex-column align-center" cols="12" sm="12" md="3">
                 <v-img class="align-center" :src="require(`@/assets/icons/${servicesIcon3}`)" width="50" height="50"></v-img>
                <h3 class="red--text">{{heading3}}</h3>
                 <p class="grey--text">{{info3}}</p>
                
            </v-col>

            <v-col class="text-center  d-flex flex-column align-center" cols="12" sm="12" md="3">
                 <v-img class="align-center" :src="require(`@/assets/icons/${servicesIcon4}`)" width="50" height="50"></v-img>
                <h3 class="red--text">{{heading4}}</h3>
                 <p class="grey--text">{{info4}}</p>
                
            </v-col>

        </v-row>

        <v-row
        align="center"
        justify="center"
        >
            <v-col class="text-center  d-flex flex-column align-center" cols="12" sm="12" md="3">
                 <v-img class="align-center" :src="require(`@/assets/icons/${servicesIcon5}`)" width="50" height="50"></v-img>
                <h3 class="red--text">{{heading5}}</h3>
                 <p class="grey--text">{{info5}}</p>

            </v-col>

            <v-col class="text-center  d-flex flex-column align-center" cols="12" sm="12" md="3">
                 <v-img class="align-center" :src="require(`@/assets/icons/${servicesIcon6}`)" width="50" height="50"></v-img>
                <h3 class="red--text">{{heading6}}</h3>
                 <p class="grey--text">{{info6}}</p>
                
            </v-col>

            <v-col class="text-center  d-flex flex-column align-center" cols="12" sm="12" md="3">
                 <v-img class="align-center" :src="require(`@/assets/icons/${servicesIcon7}`)" width="50" height="50"></v-img>
                <h3 class="red--text">{{heading7}}</h3>
                 <p class="grey--text">{{info7}}</p>
                
            </v-col>

            <v-col class="text-center  d-flex flex-column align-center" cols="12" sm="12" md="3">
                 <v-img class="align-center" :src="require(`@/assets/icons/${servicesIcon8}`)" width="50" height="50"></v-img>
                <h3 class="red--text">{{heading8}}</h3>
                 <p class="grey--text">{{info8}}</p>
                
            </v-col>

        </v-row>
    </v-container>

    



</template>


<script>
export default {
    name: 'ServicesContact',
    props: {
        servicesIcon1: { type: String, default: "rice.png" },
        servicesIcon2: { type: String, default: "party-popper.png" },
        servicesIcon3: { type: String, default: "ring.png" },
        servicesIcon4: { type: String, default: "cake-variant.png" },
        servicesIcon5: { type: String, default: "truck-outline.png" },
        servicesIcon6: { type: String, default: "grill-outline.png" },
        servicesIcon7: { type: String, default: "account-tie-outline.png" },
        servicesIcon8: { type: String, default: "noodles-black.png" },
        heading1: { type: String, default: "Dine In"},
        heading2: { type: String, default: "Private Celebration"},
        heading3: { type: String, default: "Wedding Service"},
        heading4: { type: String, default: "Birthday Parties"},
        heading5: { type: String, default: "Delivery"},
        heading6: { type: String, default: "Cooking Events"},
        heading7: { type: String, default: "Corporate Functions"},
        heading8: { type: String, default: "Heading"},
        info1: { type: String, default: "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Eum ut beatae sapiente! Rem, ad sum."},
        info2: { type: String, default: "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Eum ut beatae sapiente! Rem, ad sum."},
        info3: { type: String, default: "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Eum ut beatae sapiente! Rem, ad sum."},
        info4: { type: String, default: "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Eum ut beatae sapiente! Rem, ad sum."},
        info5: { type: String, default: "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Eum ut beatae sapiente! Rem, ad sum."},
        info6: { type: String, default: "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Eum ut beatae sapiente! Rem, ad sum."},
        info7: { type: String, default: "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Eum ut beatae sapiente! Rem, ad sum."},
        info8: { type: String, default: "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Eum ut beatae sapiente! Rem, ad sum."},
        
        
    },
    data() {
        return {
        }
    }

}
</script>

<style lang="less" scoped>



</style>