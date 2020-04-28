<template>
    <section id="menuitems-section" class="d-flex align-center">
        <v-container>
            <div>
                <h1 class="display-3 font-weight-bold mt-10 mb-10">{{title}}</h1>
            </div>
            <FilteredMenuList/>
            <template v-if="showButton">
                <div class="text-center">
                    <v-btn depressed rounded large color="amber accent-3" class="mt-5 mb-5" :to="`${link}`">View our menu</v-btn>
                </div>
            </template>
</v-container>
</section>
</template>

<script>
import FilteredMenuList from '@/components/menu/FilteredMenuList'


export default {
    name: 'HomeTopPicksSection',
    components: {
        FilteredMenuList,
    },
   props: {
        showButton: { type: Boolean, default: true },
        title: { type: String, default: "Not Set"},
        link: { type: String, default: "#"}
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