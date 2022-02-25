import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";

import { CalculatorComponent } from './calculator.component'

@NgModule({
    declarations: [CalculatorComponent],
    imports: [FormsModule],
    providers: [],
    bootstrap: [CalculatorComponent],
    /**
     * it makes all the assets mentioned in the array available to the assets of another module, considering this module is registered with that another module
     */
    exports: [CalculatorComponent]
})
export class CalculatorModule {

}