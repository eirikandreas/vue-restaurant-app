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
    props: {
        showButton: { type: Boolean, default: true },
        title: { type: String, default: "Not Set"},
        link: { type: String, required: true, default: "#"}
    },
    components: {
        FilteredMenuList,
    },
}
</script>
<style scoped>
#menuitems-section {
    min-height: 650px;
}
</style>