import VueAxios from './plugins/axios'
import Vue from 'vue'
Vue.use(VueAxios, axios)
const host = location.hostname;
axios.defaults.baseURL = `https://localhost:5001/api`
axios.defaults.port = '5001'

//for other URL and creating instance
//Vue.prototype.$http = 'https://localhost:5001/'
//const authInstance = axios.create({
//    baseURL: 'https://localhost:5002/auth'
//})
//this.axios.post('/signupNewUser?key=[API_KEY]')
//this.$auth.post('/signupNewUser?key=[API_KEY]')

//Vue.prototype.$http = authInstance
//resource
//https://codepen.io/andersschmidt/post/vuejs-axios-tip-setting-up-multiple-baseurls-using-axios-instances-and-vue-instance-properties
/*
 * let baseUrl = ''
if (process.env.NODE_ENV === 'production') {
   baseUrl = 'http://yourdomain.com/api/'
else {
   baseUrl = 'http://localhost:8000/api/'
}

export const apiHost = baseUrl
Vue.http.options.root = apiHost

*/
