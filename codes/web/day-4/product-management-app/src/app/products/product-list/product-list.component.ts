import { Component } from "@angular/core";
import { ProductModel } from "src/models/product.model";
import { ProductService } from "../../../services/product.service";
// import { productRecords } from "../../../repository/productrepository";

@Component({
    selector: 'app-product-list',
    templateUrl: './product-list.component.html',
    styleUrls: ['./product-list.component.css'],
    //component-level registartion of service
    //providers: [ProductService]
})
export class ProductListComponent {
    //productsData = productRecords;

    //ProductModel[] productsData;
    //ProductService productSvcRef;

    productsData: ProductModel[];
    //private productSvcRef: ProductService;

    //asking for dependency injection of ProductService class object
    constructor(private productSvcRef: ProductService) {
        // this.productSvcRef = new ProductService();
        this.productsData = this.productSvcRef.getProducts()
    }
}