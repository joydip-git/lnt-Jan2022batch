import { NgModule } from "@angular/core";
import { ProductListComponent } from "./product-list/product-list.component";
import { CommonModule } from "@angular/common";
import { ProductService } from "src/services/product.service";

@NgModule({
    declarations: [ProductListComponent],
    //particular module-level registration
    providers: [ProductService],
    imports: [CommonModule],
    bootstrap: [],
    exports: [ProductListComponent]
})

export class ProductsModule {

}