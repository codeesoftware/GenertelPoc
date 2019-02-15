import { Validator, Rules } from 'vee-validate';
import store from "../../store";
import Axios from "axios";


const baseUrl = "https://localhost:44388";
const isUniqueEmail = (value) => {
    return Axios.get(`${baseUrl}/api/HomeWizardApi/IsUniqueEmail`, {
        params: {
            email: value
        }
    }).then((response) => {
        return {
            valid: response.data

        };
    });

};

Validator.extend('VAL_100', {
    getMessage: field => store.state.validationMessage.messages.VAL_100,
    validate: (input, args) => {
        return Rules.required.validate(input);
    }
})
Validator.extend('VAL_103', {
    getMessage: field => store.state.validationMessage.messages.VAL_103,
    validate: (input, args) => {
        return input.indexOf(' ') !== -1;
    }
})
Validator.extend('VAL_175', {
    getMessage: field => store.state.validationMessage.messages.VAL_175,
    validate: (input, args) => {
        return Rules.between.validate(input, { min: 25, max: 55 });
    }
});

Validator.extend('VAL_206', {
    getMessage: field => store.state.validationMessage.messages.VAL_206,
    validate: (input, args) => {
        return Rules.email.validate(input);
    }
});

Validator.extend('VAL_300', {
    getMessage: field => store.state.validationMessage.messages.VAL_300,
    validate: (input, args) => {
        return input === args[0];
    }
}, { hasTarget: true });

Validator.extend('VAL_301', {
    getMessage: (field, params, data) => store.state.validationMessage.messages.VAL_301,
    validate: isUniqueEmail,
});