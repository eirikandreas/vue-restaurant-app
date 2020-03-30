<template>

    <div class="mt-p-header dashboard-bg fill-height">
<v-row>
    <v-col
    cols="12"
    md="2"
   >



        <Drawer/>
    </v-col>
    <v-col
    cols="12"
    md="10">

        <router-view class="ml-5 mr-5"/>


    </v-col>
</v-row>

        </div> 
</template>
<script>
import Drawer from './DashboardPage/Drawer.vue'
export default {
    name: "Index",
    components: {
        Drawer

    },
    data() {
        return {

        }
    },
}
</script>
<style>
.mt-p-header {
    margin-top: 0px;
}
.dashboard-bg {
    background-color: #eff1f4;
}
</style>