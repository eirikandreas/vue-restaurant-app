<template>

         <v-container class="mt-12 mb-12 ">
        <v-row 
        align="center"
        justify="center">

            <ServicesItem
                v-bind:key="service.heading"
                v-for="service in services"
                v-bind:servicesIcon="service.servicesIcon"
                v-bind:heading="service.heading"
                v-bind:info="service.info" 
            />


            

        </v-row>

    </v-container>

</template>

<script>

import ServicesItem from './ServicesItem'

export default {
    name: "servicesList",
    data(){
        return{
            services: [
                {
                servicesIcon: "rice.png",
                heading: "Dine In",
                info: "Enjoy everything from sushi bowls to spring rolls in a comfortable atmosphere with modern Asian elements."
                },

                {
                servicesIcon: "party-popper.png",
                heading: "Private Celebration",
                info: "Are you planning a big or small party? We help you serve one feast your guests will soon forget."
                },

                {
                servicesIcon: "ring.png",
                heading: "Wedding Service",
                info: "We are willing to go the extra mile to make your special day perfect. Offer guests a wide variety of dishes and enjoy the day without a single worry."
                },

                {
                servicesIcon: "cake-variant.png",
                heading: "Birthday Parties",
                info: "Arrange the coolest birthday party of the year and enjoy great food with your guests. We make the food you like best so that you can celebrate with your favorite food."
                },

                {
                servicesIcon: "truck-outline.png",
                heading: "Delivery",
                info: "Are you hungry but not able to visit us? We deliver small and large orders with food to you!"
                },

                {
                servicesIcon: "grill-outline.png",
                heading: "Cooking Events",
                info: "Enjoy late evenings without thinking about cooking. We arrange events so you can gather your friends for a tasty meal."
                },

                 {
                servicesIcon: "account-tie-outline.png",
                heading: "Corporate Functions",
                info: "Do you have a company that wants a partnership with us? We work with several companies for good prices at meetings and other events."
                },

                {
                servicesIcon: "noodles-black.png",
                heading: "Learn to Cook",
                info: "Get inspired by Asian flavors and learn how to master Asian cuisine. Learn cooking with friends or colleagues."
                },


            ]
        }
    },
    components: {
        ServicesItem
    }
    
}
</script>