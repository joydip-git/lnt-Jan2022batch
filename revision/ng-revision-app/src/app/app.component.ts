import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Welcome to Angular 13';
  receivedData = '';
  call(arg: string) {
    alert(arg);
  }
  receiveDataFromSample(data: string) {
    //alert(data)
    this.receivedData = data;
  }
}
