import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ng-auth-app';
  constructor() {
    sessionStorage.setItem('token', 'joy@gmail.com')
    localStorage.setItem('token', 'joy@gmail.com')
  }
}
