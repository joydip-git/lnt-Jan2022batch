import { Component, EventEmitter, Output } from "@angular/core";

@Component({
    selector: 'app-sample',
    templateUrl: './sample.component.html',
    styleUrls: ['./sample.component.css']
})
export class SampleComponent {
    sampleData: string = 'sample data'
    @Output() sampleDataFired: EventEmitter<string> = new EventEmitter<string>();

    fireEvent() {
        this.sampleDataFired.emit("sample data from sample component");
    }
}