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
        },
        setPageState(state, pageState, pageId) {
            console.table('setPageState');
            // let page = state.offerState.pages.find(
            //     page => page.pageId == 1
            // );
            // console.log(page);
            // page = pageState;
            //state.offerState.pages.push(pageState);

            // state.offerState.pages = [
            //     ...state.offerState.pages.filter(element => element.pageId !== 1),
            //     pageState
            // ];
            console.log(pageState);

            const object2 = Object.assign(state.offerState.pages[0], pageState);
            console.log('he');
            console.log(object2);
            state.offerState.pages[0] = object2;
            //state.offerState[pageId] = page;
        }
    },
    actions: {

    }
}