import { Component } from '@angular/core'

/*
@Component({
    selector: 'app-main',
    template: `<h2>Welcome to Angular </h2>`,
    styles: ['h2{background-color:limegreen;font-family:"Lucida Handwriting";}']
})
*/
@Component({
    selector: 'app-main',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent {
    constructor() {
        console.log('App component object created')
    }
}