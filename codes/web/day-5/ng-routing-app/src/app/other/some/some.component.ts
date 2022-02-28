import { Component } from "@angular/core";
import { ActivatedRoute } from "@angular/router";

@Component({
    template: `
        <h2>Some component</h2>
        <br>
        Data From Another Component:&nbsp;<b>{{dataFromAnother}}</b>
        <!-- 'localhost:4200/another/first data of some component/second data of some component' -->
        <br>
        <button [routerLink]="['/another',firstDataOfSome, secondDataOfSome]">Pass data to Another</button>
        `
})
export class SomeComponent {
    firstDataOfSome = 'first data of some component'
    secondDataOfSome = 'second data of some component'

    dataFromAnother = ''

    constructor(private _route: ActivatedRoute) {
        const allParams = this._route.snapshot.params
        this.dataFromAnother = allParams['data']
    }
}