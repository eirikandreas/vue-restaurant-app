<template>
<section id="menuitems-section" class="d-flex align-center">
<v-container>


     <div>
             <!--   <v-img :src="require(`@/assets/icons/${starIcon}`)" width="32px" height="32px"></v-img>

             -->
        <h1 class="display-3 font-weight-bold mt-10 mb-10">Top picks</h1>
     </div>

<MenuList/>

 <div class="text-center">
        <v-btn depressed rounded large color="amber accent-3" class="mt-5 mb-5" :to="`/menu`">View our menu</v-btn>
        </div>

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

#menuitems-section {
    min-height: 650px;
}
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