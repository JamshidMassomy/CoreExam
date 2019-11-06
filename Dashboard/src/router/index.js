import Vue from 'vue'
import Router from 'vue-router'
// Containers
const DefaultContainer = () => import('@/containers/DefaultContainer')
const HomeContainer = () => import('@/containers/HomeContainer')
const Dari = () => import('@/dari/Dari')
const Pashto = () => import('@/pashto/Pashto')
// Views
const Dashboard = () => import('@/views/admin/Dashboard')
const Applicant = () => import('@/views/admin/Applicant')
const Login = () => import('@/views/admin/Login')
const Question = () => import('@/views/admin/Question')
const NotFound = () => import('@/views/error/Page404')
Vue.use(Router)

function configRoutes() {
    return [
    {
        path: '/',
        name: 'home',
        component: HomeContainer
    },
    {
        path: '/pashto',
        name: 'Pashto',
        component: Pashto
       
    },
    {
        path: '/dari',
        name: 'Dari',
        
        component: Dari
    },
    {
        path: '/404',
        name: 'not found',
        component: NotFound
    },
    {
        path: '*',
        redirect: '/404'
           
    },
    {
      path: '/admin',
      name: 'admin',
      component: DefaultContainer,
      children:
      [
        {
            path: '/admin/dashboard',
            name: 'admin-home',
            component: Dashboard

        },
        {
          path: '/admin/login',
          name: 'login',
          component: Login
        },
        {
          path: '/admin/question',
          name: 'question',
          component: Question
        },
        {
          path: '/admin/applicant',
          name: 'applicant',
          component: Applicant
        }
      ]
      }, 
      {
          path: '/Question',
          name:'Question',
          component: DefaultContainer,
      },
      {
          path: '/Login',
          name: 'Login',
          component: Login
      }



      
    //{
    //  path: '/Home',
    //  name: 'Home',
    //  redirect: '/Home',
    //  component: Home,

    //},
    //{
    //  path: '/admin',
    //  redirect: '/admin/Dashboard',
    //  name: 'Pages',
    //  component: {
    //    render(c) { return c('router-view') }
    //  },
    //  children: [
    //    {
    //      path: 'login',
    //      name: 'Login',
    //      component: Login
    //    }
    //  ]
    //}
  ]
}

export default new Router({
  mode: 'hash', // https://router.vuejs.org/api/#mode
  linkActiveClass: 'open active',
  scrollBehavior: () => ({ y: 0 }),
  routes: configRoutes()
})
