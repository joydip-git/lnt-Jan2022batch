import { Component, Input, Output } from "@angular/core";
import { EventEmitter } from "@angular/core";

@Component({
    selector: 'app-nested',
    templateUrl: './nested.component.html',
    styleUrls: ['./nested.component.css']
})
export class NestedComponent {
    //this property will be used to accept data from the parent component
    @Input() dataFromParent: string = '';
    nestedData: string = 'data from child (Nested) component'

    @Output() emitNestedData: EventEmitter<string> = new EventEmitter<string>();

    sendDataToParent() {
        this.emitNestedData.emit(this.nestedData)
    }

}