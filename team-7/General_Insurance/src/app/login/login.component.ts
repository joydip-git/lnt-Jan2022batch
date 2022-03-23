
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators,FormBuilder } from '@angular/forms';

import { ActivatedRoute, Params, Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
 

  private _login: FormGroup = this._lb.group(
    {
    
    email: [ '', [Validators.required, Validators.email]],  
      
    passwordr: [ '',  [Validators.required]]
    
    }
);
public get login(): FormGroup {
    return this._login;
}
public set login(value: FormGroup) {
    this._login = value;
}
constructor(private _lb: FormBuilder,private router: Router,private route:ActivatedRoute) { }

  ngOnInit(): void {
    

    
  }
  

  
  submitData() {
    console.log(this.login)
  }
}