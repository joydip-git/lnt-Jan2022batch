import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'product-management-app';
  numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0]
  choice = 0;

  changeChoice(ch: number) {
    this.choice = ch
  }
}
