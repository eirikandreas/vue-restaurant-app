<template>  
    <v-container>
        <v-row>
            <v-col cols="12" sm="12" md="6">
                <v-img :src="require(`@/assets/${infoImage}`)" width="70vw" height="100vh"></v-img>
            </v-col>

            <v-col cols="12" sm="12" md="6">
                <h2>Hello</h2>
                <p>Lorem ipsum dolor 
                    sit amet consectetur 
                    adipisicing elit. Dolore 
                    aspernatur placeat provident</p>
            </v-col>
        </v-row>
    </v-container>

    



</template>


<script>
export default {
    name: 'AboutInfo',
    props: {
        infoImage: { type: String, default: "chef.jpg" },
    },
    data() {
        return {
        }
    }

}
</script>

<style lang="less" scoped>



</style>