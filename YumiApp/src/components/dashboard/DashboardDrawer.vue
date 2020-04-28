<template>
  <div>

    <v-navigation-drawer
    permanent
    :mini-variant="$vuetify.breakpoint.smAndDown"
    mini-variant-width="57"
    color="grey darken-4"
    height="100%"
    >
      <v-list dense rounded>
        <v-list-item
        v-for="item in items"
        :key="item.title"
        :to="item.link"
        color="amber accent-3"
        dark
        >
          <v-list-item-icon>
            <v-icon>{{ item.icon }}</v-icon>
          </v-list-item-icon>
          <v-list-item-content>
            <v-list-item-title>{{ item.title }}</v-list-item-title>
          </v-list-item-content>
        </v-list-item>
      </v-list>
    </v-navigation-drawer>

  </div>
</template>
<script>
export default {
    name: 'DashboardDrawer',
     data () {
      return {
        drawer: true,
        mini: false,
        items: [
          { title: 'View Orders', icon: 'mdi-bell-outline', link: "/admin/orders" },
          { title: 'Inbox', icon: 'mdi-message-outline', link: "/admin/inbox" },
          { title: 'Edit Menu', icon: 'mdi-pencil-outline', link: "/admin/editmenu" },
          { title: 'Page Settings', icon: 'mdi-cogs', link: "/admin/pagesettings" },
          
        ]
      }
    },
    
}
</script>