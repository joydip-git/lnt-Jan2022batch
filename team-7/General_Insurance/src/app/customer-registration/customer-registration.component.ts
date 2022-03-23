import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ConfirmedValidator } from 'src/app/validators/confirm-password-validator';
import { passwordValidator} from 'src/app/validators/password-validators';



@Component({

  selector: 'app-registration-form',
  templateUrl: 'customer-registration.component.html',
 
})
export class  CustomerRegistrationComponent implements OnInit {
  
    
    private _registrationform: FormGroup = this._fb.group({
        Name: ['',
            [Validators.required]
        ],
        username: [
            '',
            [Validators.required, Validators.email]
        ],
       
        Address :['',[Validators.required]],
        password: [
            '',
            [
                Validators.required,
                passwordValidator(6,10)
            ]
        ],
        retypepassword: [
            '',
            [
                Validators.required
                
            ]
        ],
        phnnumber: [
          '',
          [
              Validators.required
              
          ]
         
        ]

    },
    
    { 
        validator: ConfirmedValidator('password', 'retypepassword')
      }
    
    
    
    
    );
    public get registrationform(): FormGroup {
        return this._registrationform;
    }
    public set registrationform(value: FormGroup) {
        this._registrationform = value;
    }
    
      constructor(private _fb: FormBuilder) { }
    
      ngOnInit(): void {
       


      }
    
      submitData() {
        console.log(this.registrationform)
      }
    }
  
    
    
      
    