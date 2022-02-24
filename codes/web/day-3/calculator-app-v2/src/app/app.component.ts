import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Calculator App';
  result = 0
  firstNumber: string = ''
  secondNumber = ''
  choice = 0

  saveSelection(choice: number) {
    this.firstNumber = ''
    this.secondNumber = ''
    this.choice = choice
  }
  calculate() {
    switch (this.choice) {
      case 1:
        this.result = Number(this.firstNumber) + Number(this.secondNumber)
        break;

      case 2:
        this.result = Number(this.firstNumber) - Number(this.secondNumber)
        break;

      case 3:
        this.result = Number(this.firstNumber) * Number(this.secondNumber)
        break;

      case 4:
        this.result = Number(this.firstNumber) / Number(this.secondNumber)
        break;

      default:
        window.alert('make a proper choice')
        this.result = 0
        break;
    }
  }
}
