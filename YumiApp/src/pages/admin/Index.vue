<template>
    <div class="mt-p-header dashboard-bg fill-height">

        <router-view class="ml-5 mr-5"/>

        </div> 
</template>
<script>
export default {
    name: "Index",
    components: {

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