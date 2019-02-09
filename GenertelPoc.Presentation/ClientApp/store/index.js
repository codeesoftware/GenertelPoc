import Vue from 'vue';
import Vuex from 'vuex';
import WizardModule from './wizard';

Vue.use(Vuex);

export default new Vuex.Store({
    strict: true,
    modules: { wizard: WizardModule }
});