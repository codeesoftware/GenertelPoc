import { Validator } from 'vee-validate';

Validator.extend('VAL_100', {
    getMessage: field => 'Kérem, ezt a mezőt feltétlenül töltse ki!',
    validate: (input, args) => {
        if (input.length > 0) {
            return true;
        } else {
            return false;
        }
    }
});
Validator.extend('VAL_103', {
    getMessage: field => 'Kérjük, adja meg  a teljes nevet!',
    validate: (input, args) => {
        return input.indexOf(' ') !== -1;
    }
});

// const isBetween = (value, { min, max } = {}) => {

// const isBetween2 = {
//     getMessage(field, args) {
//         return 'minike';
//         // will be added to default locale messages.
//         // Returns a message.
//     },
//     validate(value, args) {
//         return Number(args.min) <= value && Number(args.max) >= value
//         // Returns a Boolean or a Promise that resolves to a boolean.
//     }
// }
// //     return Number(min) <= value && Number(max) >= value;
// // };

// // The first param is called 'min', and the second is called 'max'.
// const paramNames = ['min', 'max'];

// Validator.extend('betweenke', isBetween2, {
//     paramNames //  pass it in the extend options.
// });