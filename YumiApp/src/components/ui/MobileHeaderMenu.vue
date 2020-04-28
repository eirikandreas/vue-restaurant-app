<template>
    <div>
        <v-menu min-width="100%" height="100vh" flat tile nudge-top offset-y>
            <template v-slot:activator="{ on }">
                <v-btn
                dark
                icon
                v-on="on"
                close-on-click
                close-on-content-click
                class="hidden-md-and-up"
                >
                    <v-icon>mdi-menu</v-icon>
                </v-btn>
            </template>

            <v-card>
                <v-list>
                    <v-list-item v-for="(link, index) in links" :key="index">
                        <v-list-item-title><v-btn text :to="link.to">{{ link.title }}</v-btn></v-list-item-title>
                    </v-list-item>
                </v-list>
            </v-card>
        </v-menu>
    </div>
</template>
<script>
export default {
    name: 'MobileHeaderMenu',
    props: { links: { type: Array} }
}
</script>