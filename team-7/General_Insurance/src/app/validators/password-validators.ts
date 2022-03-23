import { AbstractControl, PatternValidator, ValidationErrors, ValidatorFn } from "@angular/forms"
//import { strictEqual } from "assert";


export function passwordValidator(minlen: number, maxlen: number): ValidatorFn {

    
    const passwordvalidatorlogic = function (control: AbstractControl): ValidationErrors | null {
        const pwd: string = <string>control.value;
       
        if (pwd.length < minlen)
            return {
                minlengtherror: 
                {
                    expectedlength: minlen,
                    currentlength: pwd.length
                }
            }

        if (pwd.length > maxlen)
            return {
                maxlengtherror: 
                {
                    expectedlength: maxlen,
                    currentlength: `${pwd.length}`
                }
            }

        let upperExists = false
        for (let i = 0; i < pwd.length; i++)
         {
            if (pwd[i] >= 'A' && pwd[i] <= 'Z') 
            {
                upperExists = true
                break;
            }
        }

        let lowercaseExists = false
        for (let i = 0; i < pwd.length; i++) 
        {
            if (pwd[i] >= 'a' && pwd[i] <= 'z')
             {
                lowercaseExists = true
                break;
            }
        }

        let digitExists = false
        for (let i = 0; i < pwd.length; i++)
         {
            if (pwd[i] >= '0' && pwd[i] <= '9') 
            {
                digitExists = true
                break;
            }
        }
                                                                              

        if (!upperExists)
            return { uppercase: 'Atleast provide 1 uppercase letter' }
       
        if (!lowercaseExists)
            return { lowercase: 'Atleast provide 1 lowercase letter ' }
       
        if (!digitExists)
            return { digit: 'Atleast provide 1 digit ' }

        

        return null;
    }

    return passwordvalidatorlogic


      
  
       
           
}
