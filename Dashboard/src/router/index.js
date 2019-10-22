import Vue from 'vue'
import Router from 'vue-router'
// Containers
const DefaultContainer = () => import('@/containers/DefaultContainer')
const HomeContainer = () => import('@/containers/HomeContainer')
// Views
const Dashboard = () => import('@/views/admin/Dashboard')
const ApplicantRegistrations = () => import('@/views/admin/ApplicantRegistrations')
const Login = () => import('@/views/admin/Login')
const QuestionRegistrations = () => import('@/views/admin/QuestionRegistrations')
Vue.use(Router)

function configRoutes() {
    return [
    {
        path: '/',
        name: 'home',
        component: HomeContainer
    },
    {
      path: '/admin',
      name: 'admin',
        component: DefaultContainer,
      children:
      [
        {
          path: '/Question',
              name: 'Question',
          component: Login
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
