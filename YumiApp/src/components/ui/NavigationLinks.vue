<template>
    <div class="d-flex">
        <div class="hidden-sm-and-down mx-auto" v-for="(link, index) in links" :key="index">
            <v-btn text :to="`${link.to}`">{{ link.title }} </v-btn>
        </div>
    </div>
</template>
<script>
export default {
    name: "NavigationLinks",
    props: {
        links: { type: Array }
    },
}
</script>