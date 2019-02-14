import Vue from 'vue';
import Vuex from 'vuex';
import ValidationMessage from './modules/validationMessage';

Vue.use(Vuex);

Vue.config.devtools = true; //vue dev toolsnak kell, hogy lassa a vuexet
export default new Vuex.Store({
    strict: true,
    modules: {
        validationMessage: ValidationMessage
    }
});