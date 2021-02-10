import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import Axios from 'axios'
import Querystring from 'querystring'
import './assets/main.css'

Vue.config.productionTip = false

Vue.prototype.$user = {};

Vue.prototype.$header = {};

Vue.prototype.$http = {};

Vue.mixin({
    data: function () {
        return {
            clientToken: ''
        }
    },
    methods: {
        logOut: function () {
            alert("I'm a global function");
        }
    }
});

const data = {
    grant_type: "client_credentials",
    client_id: "doctor-web",
    client_secret: "aSBhbSBhIGRvY3Rvcg=="
};

new Vue({
  router,
    store,
    beforeCreate: function () {
        Vue.prototype.$user = JSON.parse(sessionStorage.getItem('data')!);
        console.log(Vue.prototype.$user); 
        //localStorage.clear();

        //axios call to get token and set to clientToken
        Axios.post(Vue.prototype.$user.apiPath + 'connect/token', Querystring.stringify(data, '&', '=', null))
            .then(response => {
                console.log(response.data);
                Vue.prototype.$header = "bearer " + response.data.access_token;
                console.log('userresponse ' + response.data.access_token);
            })
            .catch((error) => {
                console.log('error ' + error);
            });

        Vue.prototype.$http = Axios.create({
            baseURL: Vue.prototype.$user.apiPath,
            timeout: 5000,
            headers: {
                'Authorization': Vue.prototype.$header,
                'Content-Type' : 'application/json'
            }
        });
    },
  render: h => h(App)
}).$mount('#app')
