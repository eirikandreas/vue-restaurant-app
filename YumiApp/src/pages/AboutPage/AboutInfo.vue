<template>  
    <v-container class="mt-12 mb-12" >
        <v-row>
            <v-col cols="12" sm="12" md="6">
                <v-img :src="require(`@/assets/${infoImage}`)" width="500px" height="600px"></v-img>
            </v-col>

            <v-col cols="12" sm="12" md="6">
                <h2>{{heading}}</h2>
                <p>{{info}}</p>
                <h2>{{heading2}}</h2>
                <p>{{info2}}</p>
                
            </v-col>
        </v-row>
    </v-container>

    



</template>


<script>
export default {
    name: 'AboutInfo',
    props: {
        infoImage: { type: String, default: "chef.jpg" },
        heading: { type: String, default: "Heading"},
        info: { type: String, default: "Information text"},
        heading2: { type: String, default: "Heading2"},
        info2: { type: String, default: "Information text 2"},

    },
    data() {
        return {
        }
    }

}
</script>

<style lang="less" scoped>



</style>