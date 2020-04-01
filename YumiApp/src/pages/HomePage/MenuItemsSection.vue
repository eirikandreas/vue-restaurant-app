<template>
<section id="menuitems-section">
<v-container>


     <div>
             <!--   <v-img :src="require(`@/assets/icons/${starIcon}`)" width="32px" height="32px"></v-img>

             -->
        <h1 class="display-3 font-weight-bold mt-10 mb-10">Top picks</h1>
     </div>

<MenuList/>



</v-container>
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
            starIcon: 'star.png',
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