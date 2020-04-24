<template>  
    <v-container class="mt-12 mb-12" >
        <v-row
        align="center"
        justify="center">
            <v-col class="text-center  d-flex flex-column align-center" cols="12" sm="12" md="4">
                <v-img :src="require(`@/assets/images/${teamImage1}`)" width="200px" height="400px"></v-img>
                <h3>{{heading1}}</h3>
                 <p>{{info1}}</p>

            </v-col>

            <v-col class="text-center  d-flex flex-column align-center" cols="12" sm="12" md="4">
                <v-img :src="require(`@/assets/images/${teamImage2}`)" width="200px" height="400px"></v-img>
                <h3 >{{heading2}}</h3>
                 <p>{{info2}}</p>
                
            </v-col>

            <v-col class="text-center  d-flex flex-column align-center" cols="12" sm="12" md="4">
                <v-img :src="require(`@/assets/images/${teamImage3}`)" width="200px" height="400px"></v-img>
                <h3>{{heading3}}</h3>
                 <p>{{info3}}</p>
                
            </v-col>

        </v-row>
    </v-container>

    



</template>


<script>
export default {
    name: 'AboutTeam',
    props: {
        teamImage1: { type: String, default: "team1.jpeg" },
        teamImage2: { type: String, default: "team2.jpeg" },
        teamImage3: { type: String, default: "team3.jpeg" },
        heading1: { type: String, default: "Heading"},
        heading2: { type: String, default: "Heading"},
        heading3: { type: String, default: "Heading"},
        info1: { type: String, default: "Information text"},
        info2: { type: String, default: "Information text"},
        info3: { type: String, default: "Information text"},
        

    },
    data() {
        return {
        }
    }

}
</script>

<style lang="less" scoped>



</style>