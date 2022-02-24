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
//model-view-viewmodel (MVVM)
//MVC (model-virew-controller)
//message, personName etc. are model data
//the design of the component is view
//the component class is the controller, controlling how the data flows between the design and the code (to and from)
export class AppComponent {
    people: string[] = ['joydip', 'amnil', 'sunil']
    employees = [{
        name: 'anil', id: 1, salary: 1000, location: 'bangalore'
    }, {
        name: 'anil', id: 1, salary: 1000, location: 'bangalore'
    }, {
        name: 'anil', id: 1, salary: 1000, location: 'bangalore'
    }]
    //everything in the class are by default 'public' in TS
    //component data or model or component property
    message: string = 'Soumya';
    pWidth: number = 200; //=> "200"
    pId: string = "namePara"
    personName: string = "NA";

    constructor() {
        console.log('App component object created')
    }
    callMe(val: string) {
        window.alert(`welcome ${val}`)
        //$"{}"
    }

    // show(val: string) {
    //     this.personName = val
    //     console.log(this.personName)
    // }
}