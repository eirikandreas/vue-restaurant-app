<template>
    <div>
        <v-card dark>
            <v-img :src="require(`@/assets/images/${image}`)" class="pa-0" height="400">
                <div class="overlay-gradient d-flex flex-column justify-end">
                    <v-card-title color="#FFC400" class="display-1 amber--text">{{name}}</v-card-title>
                    <v-card-text>{{text}}</v-card-text>
                </div>  
            </v-img>
        </v-card>
    </div>
</template>
<script>
export default {
    name: 'AboutTeamList',
    props: {
        image: { type: String, default: 'default.jpg'},
        name: { type: String, default: 'Not Set'},
        text: { type: String, default: 'Not Set'}
    }
}
</script>
<style scoped>
.overlay-gradient {
  height: 400px;
  background: -moz-linear-gradient(bottom, rgba(0,0,0,0.65) 0%, rgba(0,0,0,0) 100%); /* FF3.6-15 */
  background: -webkit-linear-gradient(bottom, rgba(0,0,0,0.65) 0%,rgba(0,0,0,0) 100%); /* Chrome10-25,Safari5.1-6 */
  background: linear-gradient(to top, rgba(0,0,0,0.65) 0%,rgba(0,0,0,0) 100%); /* W3C, IE10+, FF16+, Chrome26+, Opera12+, Safari7+ */
}
</style>