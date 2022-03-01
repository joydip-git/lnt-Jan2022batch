import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, Validators } from '@angular/forms';
import { passwordValidator } from '../custom-validators/password-validator';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent implements OnInit {

  // username: FormControl = new FormControl('abc@def.com')
  // password: FormControl = new FormControl('')

  // loginform: FormGroup = new FormGroup({
  //   username: new FormControl(
  //     '',
  //     [
  //       Validators.required,
  //       Validators.email
  //     ]
  //   ),
  //   password: new FormControl(
  //     '',
  //     [
  //       Validators.required,
  //       Validators.minLength(6),
  //       Validators.maxLength(10)
  //     ]
  //   )
  // })

  loginform: FormGroup = this._fb.group({
    username: [
      '',
      [Validators.required, Validators.email]
    ],
    password: [
      '',
      [
        Validators.required,
        passwordValidator(6, 10)
      ]
    ]
  })

  constructor(private _fb: FormBuilder) { }

  ngOnInit(): void {
  }

  submitData() {
    console.log(this.loginform)
  }
}
