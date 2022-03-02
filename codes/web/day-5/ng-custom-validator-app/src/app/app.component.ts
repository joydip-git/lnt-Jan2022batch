import { Component } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { uppercaseValidator } from './data-validator';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ng-custom-validator-app';
  inputdata = new FormControl(
    '',
    [
      Validators.required,
      uppercaseValidator()
    ]
  )
  submit() {
    console.log(this.inputdata)
  }
}
