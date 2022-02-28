import { Component } from "@angular/core";

@Component({
    //do not use selector property if you think this is going to be a routed component. If this is going to be a nested component, then only use selector property
    //selector:'app-another',
    template: `<h2>Another Component</h2>`
})
export class AnotherComponent {

}