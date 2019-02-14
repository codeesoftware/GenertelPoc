export default {
    namespaced: true,
    state: {
        messages: Object
    },

    mutations: {
        setMessages(state, newMessages) {
            console.log("setMessages");
            state.messages = newMessages;
            console.log(state.messages);
            // console.log(state.messages.VAL_100);

        }
    },
    actions: {

    }
}