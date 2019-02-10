export default {
    namespaced: true,
    state: {
        offerState: Object
    },

    mutations: {
        setOfferState(state, offerState) {
            state.offerState = offerState;
        },
        setPageState(state, { pageState, pageId }) {
            debugger
            let page = state.offerState.pages.find(
                page => page.pageId == pageId
            );
            page = Object.assign(page, pageState);
        }
    },
    actions: {

    }
}