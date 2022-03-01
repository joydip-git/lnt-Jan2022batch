import { Directive, Input } from "@angular/core";
import { AbstractControl, NG_VALIDATORS, ValidationErrors, Validator, ValidatorFn } from "@angular/forms";

@Directive({
    selector: '[appLengthValidator]',
    providers: [{
        provide: NG_VALIDATORS,
        useExisting: LengthValidatorDirective,
        multi: true
    }]
})
export class LengthValidatorDirective implements Validator {
    @Input('appLengthValidator') lenvalidator = 0

    validate(control: AbstractControl): ValidationErrors | null {
        console.log('validator called')
        const data = <string>control.value
        if (data.length < this.lenvalidator) {
            return { lengtherror: 'length should be greater than or equal to 5' }
        } else
            return null
    }
}