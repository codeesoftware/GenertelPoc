export default {
    namespaced: true,
    state: {
        messages: Object
    },

    mutations: {
        setMessages(state, data) {
            state.messages = data.validationMessages;
        }
    },
    actions: {

    }
}