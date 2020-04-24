import Vue from 'vue'
import VueRouter from 'vue-router'
import HomePage from '../pages/HomePage/Index.vue'


import DashboardOrdersTable from '../pages/DashboardPage/DashboardOrdersTable.vue'
import DashboardMenuTable from '../pages/DashboardPage/DashboardMenuTable.vue'
import DashboardPageSettings from '../pages/DashboardPage/DashboardPageSettings.vue'


import NotFound from '../components/common/NotFound.vue'

import init from '../components/unsorted/init.vue'
import Cart from '../components/cart/Index.vue'


import DisplayCategories from '../pages/MenuPage/DisplayCategories'
import DisplayAll from '../pages/MenuPage/DisplayAll'
import DisplaySearch from '../pages/MenuPage/DisplaySearch'

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
        component: DisplayAll
      },

      {
        path: ':category',
        component: DisplayCategories
      },
      {
        path: ':category/:id',
        name: 'MenuItemDetails',
        component: () => import(/* webpackChunkName: "menuitemdetails" */ '../components/menu/MenuItemDetails.vue')
      },
      {
        path: 'search', name: 'search', component: DisplaySearch, props: (route) => ({ query: route.query.q })
      }
    ]
  },
  {
    path: '/admin',
    name: 'Admin',
    component: () => import(/* webpackChunkName: "admin" */ '../pages/DashboardPage/Index.vue'),
    children: [
      {
        path: 'orders',
        component: DashboardOrdersTable
      },
      {
        path: 'editmenu',
        component: DashboardMenuTable
      },
      {
        path: 'pagesettings',
        component: DashboardPageSettings
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
  routes,
  scrollBehavior (to, from, savedPosition) {
    if (savedPosition) {
      return savedPosition
    } if (to.hash) {
      return {
        selector: to.hash
        // , offset: { x: 0, y: 10 }
      } }  else {
      return { x: 0, y: 0 }
    }
  }
  
})

export default router
