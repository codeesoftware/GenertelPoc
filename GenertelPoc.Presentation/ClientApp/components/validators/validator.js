import { Validator } from 'vee-validate';

Validator.extend('sandor', {
    getMessage: field => 'The ' + field + ' value is not sandor.',
    validate: value => value === 'sandor'
});


// const isBetween = (value, { min, max } = {}) => {

const isBetween2 = {
    getMessage(field, args) {
        return 'minike';
        // will be added to default locale messages.
        // Returns a message.
    },
    validate(value, args) {
        return Number(args.min) <= value && Number(args.max) >= value
        // Returns a Boolean or a Promise that resolves to a boolean.
    }
}
//     return Number(min) <= value && Number(max) >= value;
// };

// The first param is called 'min', and the second is called 'max'.
const paramNames = ['min', 'max'];

Validator.extend('betweenke', isBetween2, {
    paramNames //  pass it in the extend options.
});