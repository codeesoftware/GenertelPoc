import Vue from 'vue';
import VueRouter from 'vue-router';
import App from './components/App.vue';
import "bootstrap/dist/css/bootstrap.min.css";

import store from './store';
import ArchWizard from "./components/wizard/ArchWizard.vue"

Vue.use(VueRouter);

const routes = [
    { path: "*", component: ArchWizard },
    // { path: "*", redirect: "/wizard" },
];
const router = new VueRouter({ mode: 'history', routes: routes });
new Vue({
    router: router,
    store,
    render: h => h(App)
}).$mount('#app-root');
