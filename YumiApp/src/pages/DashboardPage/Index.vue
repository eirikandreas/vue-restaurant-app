<template>
    <div class="d-flex">

        <DashboardDrawer/>
        <router-view class="ml-5 mr-5 flex-grow-1"/>
        
    </div> 
</template>
<script>
import DashboardDrawer from './DashboardDrawer'
export default {
    name: "Index",
    components: {
        DashboardDrawer
    }
}
</script>