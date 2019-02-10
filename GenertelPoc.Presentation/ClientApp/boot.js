import Vue from 'vue';
import VueRouter from 'vue-router';
import App from './components/App.vue';
import "bootstrap/dist/css/bootstrap.min.css";

import store from './store/wizard.js';
import FirstPage from './components/wizard/home/FirstPage.vue';
import SecondPage from './components/wizard/home/SecondPage.vue';
import Wizard from "./components/wizard/home/Wizard.vue"

Vue.use(VueRouter);

const routes = [
    { path: "/home/:id", component: Wizard },
    { path: "*", redirect: "/home/1" },
    // { path: "/home/1", component: FirstPage },
    // { path: "/home/2", component: SecondPage },
    // { path: "*", redirect: "/home/1" }
];
const router = new VueRouter({ mode: 'history', routes: routes });
new Vue({
    router: router,
    store,
    render: h => h(App)
}).$mount('#app-root');
Vue.config.devtools = true;