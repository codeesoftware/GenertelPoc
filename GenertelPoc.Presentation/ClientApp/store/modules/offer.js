export default {
    namespaced: true,
    state: {
        offerState: Object
    },
    // getters: {
    //     currentPageId: state => {
    //         console.table('currentPageId');
    //         // console.log(state);
    //         // console.log(state.wizard);
    //         // console.log(state.wizard.currentPageId);
    //         return state.offerState.currentPageId || 0;
    //     }
    // },
    mutations: {
        setOfferState(state, offerState) {
            console.table('setOfferState');
            state.offerState = offerState;
        }
    },
    actions: {

    }
}