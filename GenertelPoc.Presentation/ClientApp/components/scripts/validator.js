import { Validator, Rules } from 'vee-validate';
import store from "../../store";

Validator.extend('100', {
    getMessage: field => store.state.validationMessage.messages.VAL_100,
    validate: (input, args) => {
        return Rules.required.validate(input);
    }
});
Validator.extend('103', {
    getMessage: field => store.state.validationMessage.messages.VAL_103,
    validate: (input, args) => {
        return input.indexOf(' ') !== -1;
    }
});

Validator.extend('175', {
    getMessage: field => store.state.validationMessage.messages.VAL_175,
    validate: (input, args) => {
        return Rules.between.validate(input, { min: 25, max: 55 });
    }
});

Validator.extend('isBigger', (value, [otherValue]) => {
    console.log("isBigger");
    console.log(value);
    console.log(otherValue);

    return value === otherValue;
}, {
        hasTarget: true
    });
