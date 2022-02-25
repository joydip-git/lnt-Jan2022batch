import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { NumberFilterPipe } from 'src/pipes/number-filter.pipe';
//import { ProductService } from 'src/services/product.service';

import { AppComponent } from './app.component';
import { ProductsModule } from "./products/products.module";

@NgModule({
  declarations: [
    AppComponent, NumberFilterPipe
  ],
  imports: [
    BrowserModule, ProductsModule
  ],
  //root/application level registration
  //providers: [ProductService],
  bootstrap: [AppComponent]
})
export class AppModule { }
