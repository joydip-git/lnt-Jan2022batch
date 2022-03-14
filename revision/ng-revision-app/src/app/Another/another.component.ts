import { Component, Input } from "@angular/core";
@Component({
    selector: 'app-another',
    templateUrl: './another.component.html'
})
export class AnotherComponent {
    @Input() receivedDataFromParent = ''
}