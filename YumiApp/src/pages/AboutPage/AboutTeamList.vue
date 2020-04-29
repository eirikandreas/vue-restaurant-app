<template>  
    <v-container class="mt-12 mb-12">
            <div>
                <h1 class="display-3 font-weight-bold mt-10 mb-10">Our Team</h1>
            </div>
        <v-row>
            <v-col
            v-for="(item, index) in team" :key="index"  
            cols="12" 
            sm="4" 
            md="4"
            >
                <AboutTeamItem
                :image="item.image"
                :name="item.name"
                :text="item.text"
                />

            </v-col>
        </v-row>
    </v-container>
</template>
<script>
import AboutTeamItem from '@/pages/AboutPage/AboutTeamItem'

export default {
    name: 'AboutTeamList',
    components: {
        AboutTeamItem
    },
    data() {
        return {
            team: [
                {
                    name: "Jiro Ono",
                    text: "Jiro Ono has worked as a chef for many years and has experience from all over the world.",
                    image: "team1.jpg"
                },
                {
                    name: "Yoshiharu Kakinamu",
                    text: "Yoshiharu Kakinamu has worked as a chef for many years and has experience from all over the world.",
                    image: "team2.jpg"
                },
                {
                    name: "Jeff Saito",
                    text: "Jeff Saito has worked as a chef for many years and has experience from all over the world.",
                    image: "team3.jpg"
                }
            ]
        }
    }

}
</script>