import Vue from 'vue'
import VueRouter from 'vue-router'
import HomePage from '../pages/HomePage/Index.vue'
import DashboardInbox from '../pages/DashboardPage/DashboardInbox.vue'
import DashboardOrdersTable from '../pages/DashboardPage/DashboardOrdersTable.vue'
import DashboardMenuTable from '../pages/DashboardPage/DashboardMenuTable.vue'
import DashboardPageSettings from '../pages/DashboardPage/DashboardPageSettings.vue'
import PageNotFound from '../components/common/PageNotFound.vue'
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
    component: () => import(/* webpackChunkName: "about" */ '../pages/AboutPage/Index.vue')
  },
  {
    path: '/contact',
    name: 'Contact',
    // route level code-splitting
    component: () => import(/* webpackChunkName: "about" */ '../pages/ContactPage/Index.vue')
  },
  {
    path: '/menu',
    name: 'Menu',
    // route level code-splitting
    component: () => import(/* webpackChunkName: "menu" */ '../pages/MenuPage/Index.vue'),
    children: [
      {
        path: '/menu',
        component: DisplayAll
      },
      {
        path: ':category',
        component: DisplayCategories
      },
      {
        path: ':category/:id',
        name: 'MenuItemFull',
        component: () => import(/* webpackChunkName: "menuitemdetails" */ '../components/menu/MenuItemFull.vue')
      },
      {
        name: 'search', component: DisplaySearch, props: (route) => ({ query: route.query.q })
      }
    ]
  },
  {
    path: '/admin',
    name: 'Admin',
    // route level code-splitting
    component: () => import(/* webpackChunkName: "admin" */ '../pages/DashboardPage/Index.vue'),
    children: [
      {
        path: '/admin',
        component: DashboardOrdersTable
      },
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
      {
        path: 'inbox',
        component: DashboardInbox
      },
    ]
  },
  {
    path: '/checkout',
    name: 'Checkout',
    // route level code-splitting
    component: () => import(/* webpackChunkName: "checkout" */ '../pages/CheckoutPage/Index.vue')
  },
  {
    path: '*',
    component: PageNotFound
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
      } }  else {
      return { x: 0, y: 0 }
    }
  }
  
})

export default router
