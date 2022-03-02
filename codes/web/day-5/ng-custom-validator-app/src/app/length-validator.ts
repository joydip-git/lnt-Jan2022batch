import { AbstractControl, ValidationErrors, Validator, ValidatorFn } from "@angular/forms";
/*
const validateLength = (control: AbstractControl): ValidationErrors | null => {
    const inputData = <string>control.value
    if (inputData.length < 5 && inputData.length > 10)
        return {
            lengtherror:
            {
                message: 'length should be between 5 and 10',
                status: true,
                maximumength: 10,
                minimumlength: 5,
                currentlength: inputData.length
            }
        }
    else
        return null
}

export const lengthValidator = (): ValidatorFn => {
    return validateLength;
}
*/
//2.
/*
export class LengthValidator implements Validator {
    validate(control: AbstractControl): ValidationErrors | null {
        const inputData = <string>control.value
        if (inputData.length < 5 && inputData.length > 10)
            return {
                lengtherror:
                {
                    message: 'length should be between 5 and 10',
                    status: true,
                    maximumength: 10,
                    minimumlength: 5,
                    currentlength: inputData.length
                }
            }
        else
            return null
    }
    lengthValidator = (): ValidatorFn => {
        return this.validate
    }
}
*/
//3.
/*
export class LengthValidator implements Validator {
    validate(control: AbstractControl): ValidationErrors | null {
        const inputData = <string>control.value
        console.log(inputData.length)
        if (inputData.length < 5 || inputData.length > 10)
            return {
                lengtherror:
                {
                    message: 'length should be between 5 and 10',
                    status: true,
                    maximumength: 10,
                    minimumlength: 5,
                    currentlength: inputData.length
                }
            }
        else
            return null
    }
    public get Length(): ValidatorFn {
        return this.validate
    }
}
*/
//4.

export class LengthValidator {
    public static get Length(): ValidatorFn {

        const validateLength = (control: AbstractControl): ValidationErrors | null => {
            const inputData = <string>control.value
            if (inputData.length < 5 || inputData.length > 10)
                return {
                    lengtherror:
                    {
                        message: 'length should be between 5 and 10',
                        status: true,
                        maximumength: 10,
                        minimumlength: 5,
                        currentlength: inputData.length
                    }
                }
            else
                return null
        }

        return validateLength;
    }
}
