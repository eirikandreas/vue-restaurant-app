<template>

    <div class="mt-p-header dashboard-bg fill-height d-flex align-content-stretch">



        <Drawer/>

        <router-view class="ml-5 mr-5 flex-grow-1"/>



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
    min-height: 650px;
}
</style>