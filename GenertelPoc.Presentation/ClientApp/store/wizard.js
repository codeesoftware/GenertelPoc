import Vue from 'vue';
import Vuex from 'vuex';
import Offer from './modules/offer.js';

Vue.use(Vuex);

Vue.config.devtools = true; //vue dev toolsnak kell, hogy lassa a vuexet
export default new Vuex.Store({
    strict: true,
    modules: { offer: Offer }
});