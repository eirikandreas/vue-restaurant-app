<template>
    <div class="notfound d-flex align-center">
        
        <v-container class="text-center">
            <v-row>
                <v-col cols="12">
                    <v-row class="d-flex justify-center">
                        <v-col cols="12" md="12" class="d-flex flex-row align-center">
                            <v-img contain :src="require(`@/assets/icons/${notfoundImg}`)" height="128px" width="128px"></v-img>
                        </v-col>
                    </v-row>
                    <v-row>
                        <v-col>
                            <h1 class="display-4 font-weight-bold grey--text">Oops! Chopsticks!</h1>
                        </v-col>
                    </v-row>
                    <v-row>
                        <v-col cols="12">
                            <h2 class="subtitle mt-5">Chopsticks can be finicky and the page you are looking for can not be found! Dont worry!</h2>
                            <v-btn rounded depressed large color="amber accent-3 mt-5">Take me back</v-btn>
                
                        </v-col>
                    </v-row>
                </v-col>
            </v-row>
      </v-container>

  </div>
</template>
<script>
export default {
    name: 'NotFound',
    data(){
        return {
            notfoundImg: 'notfound.png'
        }
    }
}
</script>
<style scoped>
.notfound {
    min-height: 600px;
}
</style>
