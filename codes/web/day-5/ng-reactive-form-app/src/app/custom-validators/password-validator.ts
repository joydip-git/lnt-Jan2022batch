import { AbstractControl, ValidationErrors, ValidatorFn } from "@angular/forms"

//this factory function must return a function of type ValidatorFn (which says, the inner function should accept a control as an argument and must return either null or an object of type ValidationErros)
export function passwordValidator(minlen: number, maxlen: number): ValidatorFn {

    //this function should validate a control data and return ValidationErrors type object (if validation fails) or null (in case of no validation error)
    const passwordvalidatorlogic = function (control: AbstractControl): ValidationErrors | null {
        const pwd: string = <string>control.value;
        // let errors = { uppercase: '', lowercase: '', digit: '' }

        if (pwd.length < minlen)
            return {
                minlengtherror: {
                    expectedlength: minlen,
                    currentlength: pwd.length
                }
            }

        if (pwd.length > maxlen)
            return {
                maxlengtherror: {
                    expectedlength: maxlen,
                    currentlength: `${pwd.length}`
                }
            }

        let upperExists = false
        for (let i = 0; i < pwd.length; i++) {
            if (pwd[i] >= 'A' && pwd[i] <= 'Z') {
                upperExists = true
                break;
            }
        }

        let lowercaseExists = false
        for (let i = 0; i < pwd.length; i++) {
            if (pwd[i] >= 'a' && pwd[i] <= 'z') {
                lowercaseExists = true
                break;
            }
        }

        let digitExists = false
        for (let i = 0; i < pwd.length; i++) {
            if (pwd[i] >= '0' && pwd[i] <= '9') {
                digitExists = true
                break;
            }
        }

        if (!upperExists)
            return { uppercase: '1 uppercase letter should be present in the password' }
        //errors.uppercase = 'No uppercase letter in the password'

        if (!lowercaseExists)
            return { lowercase: '1 lowercase letter should be present in the password' }
        // errors.lowercase = 'No lowercase letter in password'

        if (!digitExists)
            return { digit: '1 digit should be present in the password' }

        return null;
    }

    return passwordvalidatorlogic
}