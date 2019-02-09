import Vue from 'vue';
import VueRouter from 'vue-router';

import App from './components/App.vue';
import store from './store';

Vue.use(VueRouter);

const routes = [
];

new Vue({
    //  router: new VueRouter({ mode: 'history', routes: routes }),
    store,
    render: h => h(App)
}).$mount('#app-root');
