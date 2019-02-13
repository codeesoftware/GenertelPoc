import { Validator } from 'vee-validate';

Validator.extend('sandor', {
    getMessage: field => 'The ' + field + ' value is not sandor.',
    validate: value => value === 'sandor'
});
