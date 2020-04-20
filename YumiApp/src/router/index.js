import Vue from 'vue'
import VueRouter from 'vue-router'
import HomePage from '../pages/HomePage/Index.vue'
import Dashboard from '../pages/admin/DashboardPage/Dashboard.vue'

import Orders from '../pages/admin/DashboardPage/Orders.vue'
import EditMenu from '../pages/admin/DashboardPage/EditMenu.vue'
import PageSettings from '../pages/admin/DashboardPage/PageSettings.vue'

import MenuList from '../components/menu/MenuList.vue'
import NotFound from '../components/common/NotFound.vue'

import init from '../components/unsorted/init.vue'
import Cart from '../components/unsorted/Cart.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: HomePage
  },
  {
    path: '/about',
    name: 'About',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../pages/AboutPage/Index.vue')
  },
  {
    path: '/contact',
    name: 'Contact',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../pages/ContactPage/Index.vue')
  },
  {
    path: '/menu',
    name: 'Menu',
    component: () => import(/* webpackChunkName: "menu" */ '../pages/MenuPage/Index.vue'),
    children: [
      {
        path: '',
        component: MenuList
      },

      {
        path: ':category',
        component: MenuList
      },
      {
        path: ':category/:id',
        name: 'MenuItemDetails',
        component: () => import(/* webpackChunkName: "menuitemdetails" */ '../components/menu/MenuItemDetails.vue')
      },
      {
        path: 'search', name: 'search', component: MenuList, props: (route) => ({ query: route.query.q })
      }
    ]
  },
  {
    path: '/admin',
    name: 'Admin',
    component: () => import(/* webpackChunkName: "admin" */ '../pages/DashboardPage/Index.vue'),
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
        path: 'pagesettings',
        component: PageSettings
      },
    ]
  },
  {
    path: '/cart',
    component: Cart
  },
  {
    path: '*',
    component: NotFound
  },
  {
    path: '/init',
    component: init
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
