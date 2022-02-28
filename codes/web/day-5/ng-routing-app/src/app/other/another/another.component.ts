import { Component } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";

@Component({
    //do not use selector property if you think this is going to be a routed component. If this is going to be a nested component, then only use selector property
    //selector:'app-another',
    template: `
    <h2>Another Component</h2>
    <br>
    <div>
        1st Data From Some Component:&nbsp;<b><u><i>{{firstDataFromSome}}</i></u></b>
        <br>
        2nd Data From Some Component:&nbsp;<b><u><i>{{secondDataFromSome}}</i></u></b>
    </div>
    <br>
    <!-- //navigation through design using routerLink directive -->
    <!-- <button [routerLink]="['/some',dataOfAnother]">
        Send data to Some
    </button> -->
    <button (click)="passDataToSome()")>
        Send data to Some
    </button>
    `
})
export class AnotherComponent {
    firstDataFromSome = ''
    secondDataFromSome = ''

    dataOfAnother = 'Data of Another component'

    constructor(private _route: ActivatedRoute, private _router: Router) {
        const allParams = this._route.snapshot.params
        /** { data1: 'first data of some component', data2: 'second data of some component'} */
        this.firstDataFromSome = allParams['data1']
        this.secondDataFromSome = allParams['data2']
    }
    passDataToSome() {
        //navigation through code
        this._router.navigate(['/some', this.dataOfAnother])
    }
}