import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductListComponent } from './product-list/product-list.component';
import { ProductService } from './product.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    ProductListComponent
  ],
  imports: [
    CommonModule,
    HttpClientModule
  ],
  providers: [ProductService],
  exports: [ProductListComponent]
})
export class ProductsModule { }
