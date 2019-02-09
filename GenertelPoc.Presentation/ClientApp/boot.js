import Vue from 'vue';
import VueRouter from 'vue-router';
import App from './components/App.vue';
import "bootstrap/dist/css/bootstrap.min.css";

import store from './store/wizard.js';
import ArchWizard from "./components/wizard/ArchWizard.vue"
import HomeWizard from "./components/wizard/home/HomeWizard.vue"

Vue.use(VueRouter);

const routes = [
    { path: "/home/:id", component: HomeWizard },
    { path: "*", redirect: "/home/1" }
];
const router = new VueRouter({ mode: 'history', routes: routes });
new Vue({
    router: router,
    store,
    render: h => h(App)
}).$mount('#app-root');
Vue.config.devtools = true;