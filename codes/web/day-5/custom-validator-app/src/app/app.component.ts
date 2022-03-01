import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'custom-validator-app';
  submitdata(val: any) {
    console.log(val)
  }

  // receiveDataFromRegistration(frmData: any) {
  //   console.log(frmData)
  // }
}
