import Vue from 'vue';
import VueRouter from 'vue-router';
import App from './components/App.vue';
import "bootstrap/dist/css/bootstrap.min.css";
import NProgress from "nprogress";

import store from './store/';
import Wizard from "./components/wizard/home/Wizard.vue"
import VeeValidate from 'vee-validate';
window._ = require('lodash');

Vue.use(VueRouter);
Vue.use(VeeValidate);

const routes = [
    { path: "/home/:id", component: Wizard },
    { path: "*", redirect: "/home/1" },
];
const router = new VueRouter({ mode: 'history', routes: routes });
NProgress.configure({ easing: 'ease', speed: 500 });
router.beforeEach((to, from, next) => {
    NProgress.start();
    next();
});

router.afterEach((to, from) => {
    NProgress.done();
});

new Vue({
    router,
    validator: VeeValidate,
    store,
    render: h => h(App)
}).$mount('#app-root');
Vue.config.devtools = true;