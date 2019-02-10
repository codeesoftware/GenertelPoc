export default {
    namespaced: true,
    state: {
        offerState: Object
    },
    // getters: {
    //     getPageByPageId: (state) => (pageId) => {
    //         return state.offerState.pages.find(
    //             page => page.pageId == 1
    //         );
    //     }
    // },
    mutations: {
        setOfferState(state, offerState) {
            console.table('setOfferState');
            state.offerState = offerState;
        },
        setPageState(state, { pageState, pageId }) {
            console.table('setPageState');
            let page = state.offerState.pages.find(
                page => page.pageId == pageId
            );
            console.log(pageId);
            page = Object.assign(page, pageState);
        }
    },
    actions: {

    }
}