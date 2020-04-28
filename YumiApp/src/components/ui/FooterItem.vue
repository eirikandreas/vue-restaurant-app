<template>
    <v-card color="transparent">
        <v-card-title>{{title}}t</v-card-title>
        <v-card-text class="white--text pt-0">
            {{text}}
        </v-card-text>
    </v-card>
</template>
<script>
export default {
    name: 'FooterItem',
    props: {
        title: {type: String, default: "Not Set"},
        text: {type: String, default: "Not Set"},
    }
}
</script>