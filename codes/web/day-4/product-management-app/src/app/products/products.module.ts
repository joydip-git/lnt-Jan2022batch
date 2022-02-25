import { NgModule } from "@angular/core";
import { ProductListComponent } from "./product-list/product-list.component";
import { CommonModule } from "@angular/common";

@NgModule({
    declarations: [ProductListComponent],
    providers: [],
    imports: [CommonModule],
    bootstrap: [],
    exports: [ProductListComponent]
})

export class ProductsModule {

}