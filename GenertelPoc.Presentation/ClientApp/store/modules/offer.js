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
            // page = pageState;
            //state.offerState.pages.push(pageState);

            // state.offerState.pages = [
            //     ...state.offerState.pages.filter(element => element.pageId !== 1),
            //     pageState
            // ];
            //  console.log(fullName);
            console.log(pageId);

            const object2 = Object.assign(page, pageState);
            state.offerState.pages[pageId - 1] = object2;
            //state.offerState[pageId] = page;
        }
    },
    actions: {

    }
}