<template>
    <div>
        <v-toolbar flat color="transparent">
            <v-toolbar-title>
                {{title}}
            </v-toolbar-title>
            <v-spacer></v-spacer>
            <template v-if="showButton">
            <v-btn depressed rounded color="amber accent-3">New Menu Item</v-btn>
            </template>
        </v-toolbar>

    </div>
</template>
<script>
export default {
    name: 'TableToolbar',
    props: {
        title: {type: String, default: "Not Set"},
        showButton: {type: Boolean, default: true}
    }
}
</script>