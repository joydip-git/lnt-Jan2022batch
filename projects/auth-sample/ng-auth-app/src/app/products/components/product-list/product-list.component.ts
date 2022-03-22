import { Component, OnInit } from '@angular/core';
import { Product } from '../../models/product';
import { ProductService } from '../../services/product.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

  products?: Product[];
  constructor(private ps: ProductService) { }

  ngOnInit(): void {
    this.ps.fetchProducts()
      .subscribe({
        next: (data: Product[]) => this.products = data,
        error: (err) => console.log(err),
        complete: () => console.log('data fetched')
      });
  }
}
