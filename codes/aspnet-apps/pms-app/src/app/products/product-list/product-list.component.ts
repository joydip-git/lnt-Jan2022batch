import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from 'src/app/models/Product';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

  products?: Product[];
  constructor(private _ps: ProductService) { }

  ngOnInit(): void {
    const observableOfProducts: Observable<Product[]> = this._ps.getAllProducts()
    observableOfProducts.subscribe(
      (all: Product[]) => {
        console.log(all)
        this.products = all
      }
    )
  }
}
