<template>
    <div class="d-flex fill-height">

        <DashboardDrawer/>
        <router-view class="ml-5 mr-5 flex-grow-1"/>
        
    </div> 
</template>
<script>
import DashboardDrawer from '@/components/dashboard/DashboardDrawer'
export default {
    name: "Index",
    components: {
        DashboardDrawer
    }
}
</script>