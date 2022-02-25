import { Component } from "@angular/core";
import { productRecords } from "../../../repository/productrepository";

@Component({
    selector: 'app-product-list',
    templateUrl: './product-list.component.html',
    styleUrls: ['./product-list.component.css']
})
export class ProductListComponent {
    productsData = productRecords
}