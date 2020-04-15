<template>

    <v-navigation-drawer
    dark
    color="#111111"
      :disable-resize-watcher="true"
      mobile-break-point="$vuetify.breakpoint.mdAndDown"
      :mini-variant="$vuetify.breakpoint.mdAndDown"
      min-width="60px"


  

    >

  

      <v-list dense rounded>
        <v-list-item
          v-for="item in items"
          :key="item.title"
          :to="item.link"
          color="amber accent-3"
        >
          <v-list-item-icon>
            <v-icon>{{ item.icon }}</v-icon>
          </v-list-item-icon>

          <v-list-item-content>
            <v-list-item-title>{{ item.title }}</v-list-item-title>
          </v-list-item-content>
        </v-list-item>
     




   
      <v-list-group
        v-for="item in settings"
        :key="item.title"
        v-model="item.active"
        :prepend-icon="item.icon"
        no-action
        color="amber accent-3"
      >
        <template v-slot:activator>
          <v-list-item-content>
            <v-list-item-title v-text="item.title"></v-list-item-title>
          </v-list-item-content>
        </template>

        <v-list-item
          v-for="subItem in item.items"
          :key="subItem.title"
          :to="subItem.link"
      
        >
          <v-list-item-content>
            <v-list-item-title v-text="subItem.title"></v-list-item-title>
          </v-list-item-content>
        </v-list-item>
      </v-list-group>
    </v-list>




     <!-- <template v-slot:append>
        <div class="pa-2">
          <v-btn block>Logout</v-btn>
        </div>
      </template> -->
 
    </v-navigation-drawer>
</template>
<script>
export default {
    drawer: null,
    name: 'Drawer',
     data () {
      return {
        items: [
          { title: 'Dashboard', icon: 'mdi-view-dashboard', link: "/admin/dashboard" },
          { title: 'View Orders', icon: 'mdi-bell-outline', link: "/admin/orders" },
          { title: 'Edit Menu', icon: 'mdi-pencil-outline', link: "/admin/editmenu" },
        ],
        settings: [
          { title: 'Page Settings', icon: 'mdi-cogs', link: "/admin/pagesettings", items: [ { title: 'General', link: "/admin/settingsgeneral" }, { title: 'Content', link: "/admin/settingscontent" }, { title: 'Display', link: "/admin/settingsdisplay" }, { title: 'Social', link: "/admin/settingssocial" } ] },
        ]
      }
    },
    
}
</script>