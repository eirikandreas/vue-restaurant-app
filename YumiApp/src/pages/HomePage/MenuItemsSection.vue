<template>
<section id="menuitems-section">


<MenuList/>


</section>
</template>

<script>
import MenuList from '@/components/MenuList.vue'

export default {
    name: 'MenuItemsSection',
    components: {
        MenuList
    },
    data() {
        return {
        }
    }
}
</script>
<style scoped>
.hero-font-size-sm {
    font-size: 5rem;
    line-height: 4.5rem;
}

.hero-font-size-md {
    font-size: 6rem;
    line-height: 5rem;
}

.hero-card-width {
    width: 60%;
}
</style>