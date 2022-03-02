import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { LengthValidator } from './length-validator';
// import { uppercaseValidator } from './data-validator';
import { UppercaseValidator } from './uppercase-validator';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ng-custom-validator-app';
  // inputdata = new FormControl(
  //   '',
  //   [
  //     //mention name of functions/properties which returns ValidatorFn
  //     Validators.required,
  //     // uppercaseValidator()
  //     // new UppercaseValidator().UpperCase
  //     new UppercaseValidator().uppercaseValidator(),
  //     //new LengthValidator().lengthValidator()
  //     //new LengthValidator().Length
  //     LengthValidator.Length
  //   ]
  // )
  //username = new FormControl();
  login = new FormGroup({
    username: new FormControl('', Validators.required),
    password: new FormControl('',
      [
        Validators.required,
        LengthValidator.Length
      ]
    )
  })

  submit() {
    //console.log(this.inputdata)
    console.log(this.login)
  }
}
