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
                    text: "Jiro was born and raised in Japan and has been teaching Asian cuisine since he was a little boy. He traveled to Norway to learn more about the best ingredients in the sea and has not returned since. Jiro has won several awards and specializes in making maki rolls.",
                    image: "team1.jpg"
                },
                {
                    name: "Yoshiharu Kakinamu",
                    text: "Yoshiharu came to Norway as a teenager and worked on his grandfather's sushi restaurant until he decided to open his own restaurant. Yoshiharu is passionate about the good flavors and wants his customers to have the best taste experience.",
                    image: "team2.jpg"
                },
                {
                    name: "Jeff Saito",
                    text: "Jeff Saito has always been fascinated by Japanese cuisine and is now one of Norway's most talked about sushi chefs. He believes that the perfect meal has a balanced combination of sour, sweet and salty. One of Jeff's greatest pleasures is watching others enjoy his food.",
                    image: "team3.jpg"
                }
            ]
        }
    }

}
</script>