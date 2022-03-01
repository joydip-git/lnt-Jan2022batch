import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent implements OnInit {

  // username: FormControl = new FormControl('abc@def.com')
  // password: FormControl = new FormControl('')

  // loginform: FormGroup = new FormGroup({
  //   username: new FormControl(''),
  //   password: new FormControl('')
  // })

  loginform: FormGroup = this._fb.group({
    username: [''],
    password: ['']
  })

  constructor(private _fb: FormBuilder) { }

  ngOnInit(): void {
  }

  submitData() {
    console.log(this.loginform.value)
  }
}
