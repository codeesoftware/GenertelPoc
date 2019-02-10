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
        setPageState(state, { fullName, pageId }) {
            console.table('setPageState');
            debugger;
            console.table(state);
            let page = state.offerState.pages.find(
                page => page.pageId == 1
            );
            // page = pageState;
            //state.offerState.pages.push(pageState);

            // state.offerState.pages = [
            //     ...state.offerState.pages.filter(element => element.pageId !== 1),
            //     pageState
            // ];
            console.log(fullName);
            console.log(pageId);
            console.log(page);

            const object2 = Object.assign(page, { fullName });
            console.log('he');
            console.log(object2);
            state.offerState.pages[0] = object2;
            //state.offerState[pageId] = page;
        }
    },
    actions: {

    }
}