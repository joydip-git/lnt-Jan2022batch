import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  parentData: string = 'data from parent (app) component'
  childData: string = '';

  receiveDataFromChild(data: string) {
    this.childData = data
  }
}
