<template>

    <v-navigation-drawer
      permanent
      absolute
      :width="240"
      v-model="isSmall"
      min-height="600px"
    >
           <template v-slot:prepend>
        <v-list-item two-line>
          <v-list-item-avatar>
            <img src="https://randomuser.me/api/portraits/women/81.jpg">
          </v-list-item-avatar>

          <v-list-item-content>
            <v-list-item-title>Jane Smith</v-list-item-title>
            <v-list-item-subtitle>Logged In</v-list-item-subtitle>
          </v-list-item-content>
        </v-list-item>
      </template>

      <v-divider></v-divider>

      <v-list dense>
        <v-list-item
          v-for="item in items"
          :key="item.title"
          :to="item.link"
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
          isSmall: false,
        items: [
          { title: 'Dashboard', icon: 'mdi-view-dashboard', link: "/admin/dashboard" },
          { title: 'View Orders', icon: 'mdi-bell-outline', link: "/admin/orders" },
          { title: 'Edit Menu', icon: 'mdi-pencil-outline', link: "/admin/editmenu" },
          { title: 'Users', icon: 'mdi-account-group-outline', link: "/admin/editusers" },
        ],
        settings: [
          { title: 'Page Settings', icon: 'mdi-cogs', link: "/admin/pagesettings", items: [ { title: 'General', link: "/admin/settingsgeneral" }, { title: 'Content', link: "/admin/settingscontent" }, { title: 'Display', link: "/admin/settingsdisplay" } ] },
        ]
      }
    },
    
}
</script>