<template>
    <div>
       <MenuTable/>
    </div>
</template>

<script>
import MenuTable from '@/pages/DashboardPage/DashboardMenuTable'
export default {
    name: 'DashboardEditMenu',
    components: {
        DashboardMenuTable
    },
    data() {
        return {
      
        }

    }

}
</script>

<style scoped>
.full-w {
    width: 100%;
}

.shadow {
    -webkit-box-shadow: 0px 0px 50px 0px rgba(238, 238, 238, 9);
    -moz-box-shadow: 0px 0px 50px 0px rgba(238, 238, 238, 9);
    box-shadow: 0px 0px 50px 0px rgba(238, 238, 238, 9);
}

.dashboard-bg {
    background-color: #999999;
}

.round-img {
    border-radius: 50%;
}
</style>