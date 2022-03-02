import { AbstractControl, ValidationErrors, Validator, ValidatorFn } from "@angular/forms";
/*
export function uppercaseValidator(): ValidatorFn {

    function validateData(control: AbstractControl): ValidationErrors | null {

        //if validation fails return an object of type ValidationErrors
        //if validation succeds, return null

        const inputData = <string>control.value

        let doesUppercaseExist = false
        for (let index = 0; index < inputData.length; index++) {
            const character = inputData[index];
            if (character >= 'A' && character <= 'Z') {
                doesUppercaseExist = true
                break;
            }
        }

        if (doesUppercaseExist)
            return null
        else
            return { noUpperCase: { message: 'no uppercase character', status: true } }
    }

    return validateData;
}
*/
export class UppercaseValidator implements Validator {
    validate(control: AbstractControl): ValidationErrors | null {
        //if validation fails return an object of type ValidationErrors
        //if validation succeds, return null

        const inputData = <string>control.value

        let doesUppercaseExist = false
        for (let index = 0; index < inputData.length; index++) {
            const character = inputData[index];
            if (character >= 'A' && character <= 'Z') {
                doesUppercaseExist = true
                break;
            }
        }

        if (doesUppercaseExist)
            return null
        else
            return { noUpperCase: { message: 'no uppercase character', status: true } }
    }

    // public get UpperCase(): ValidatorFn {
    //     return this.validate
    // }
    uppercaseValidator() {
        return this.validate
    }
}

// export class UppercaseValidator {

//     // public get UpperCase(): ValidatorFn {
//     //     return this.validate
//     // }
//     uppercaseValidator() {

//         const validate = (control: AbstractControl): ValidationErrors | null => {
//             //if validation fails return an object of type ValidationErrors
//             //if validation succeds, return null

//             const inputData = <string>control.value

//             let doesUppercaseExist = false
//             for (let index = 0; index < inputData.length; index++) {
//                 const character = inputData[index];
//                 if (character >= 'A' && character <= 'Z') {
//                     doesUppercaseExist = true
//                     break;
//                 }
//             }

//             if (doesUppercaseExist)
//                 return null
//             else
//                 return { noUpperCase: { message: 'no uppercase character', status: true } }
//         }
//         return validate
//     }
// } 