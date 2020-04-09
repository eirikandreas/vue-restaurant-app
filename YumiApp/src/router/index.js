import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'
import Dashboard from '../pages/admin/DashboardPage/Dashboard.vue'
import Orders from '../pages/admin/DashboardPage/Orders.vue'
import EditMenu from '../pages/admin/DashboardPage/EditMenu.vue'
import EditUsers from '../pages/admin/DashboardPage/EditUsers.vue'
import PageSettings from '../pages/admin/DashboardPage/PageSettings.vue'
import SettingsGeneral from '../pages/admin/DashboardPage/SettingsGeneral.vue'
import SettingsContent from '../pages/admin/DashboardPage/SettingsContent.vue'
import SettingsDisplay from '../pages/admin/DashboardPage/SettingsDisplay.vue'
import MenuCategoryList from '../pages/MenuPage/MenuCategoryList.vue'
import MenuSearchList from '../pages/MenuPage/MenuSearchList.vue'
import MenuList from '../pages/MenuPage/MenuList.vue'

import NotFound from '../views/NotFound.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/about',
    name: 'About',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/About.vue')
  },
  {
    path: '/menu',
    name: 'Menu',
    component: () => import(/* webpackChunkName: "menu" */ '../views/Menu.vue'),
    children: [
      {
        path: '',
        component: MenuList
      },
      {
        path: '/search/:query',
        component: MenuSearchList
      },
      {
        path: ':category',
        component: MenuCategoryList
      },
      {
        path: ':category/:id',
        name: 'MenuItemDetails',
        component: () => import(/* webpackChunkName: "menuitemdetails" */ '../components/MenuItemDetails.vue')
      },
    ]
  },
  {
    path: '/profile',
    name: 'Profile',
    component: () => import(/* webpackChunkName: "profile" */ '../views/Profile.vue')
  },
  {
    path: '/admin',
    name: 'Admin',
    component: () => import(/* webpackChunkName: "admin" */ '../pages/admin/Index.vue'),
    children: [
      {
        path: 'dashboard',
        component: Dashboard
      },
      {
        path: 'orders',
        component: Orders
      },
      {
        path: 'editmenu',
        component: EditMenu
      },
      {
        path: 'editusers',
        component: EditUsers
      },
      {
        path: 'pagesettings',
        component: PageSettings
      },
      {
        path: 'settingsgeneral',
        component: SettingsGeneral
      },
      {
        path: 'settingscontent',
        component: SettingsContent
      },
      {
        path: 'settingsdisplay',
        component: SettingsDisplay
      },
    ]
  },
  {
    path: '*',
    component: NotFound
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
