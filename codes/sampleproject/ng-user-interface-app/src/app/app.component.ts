import { HttpErrorResponse } from '@angular/common/http';
import { Component } from '@angular/core';
import { Observable, Observer } from 'rxjs';
import { ProductModel } from './models/product.model';
import { ProductService } from './sevices/product.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  products?: ProductModel[];
  selectedProduct?: ProductModel;
  errorMessage?: string;

  constructor(private _ps: ProductService) {

  }
  public get() {
    const observerObj: Observer<ProductModel[]> = {
      next: (data: ProductModel[]) => {
        console.log(data)
        this.products = data;
      },
      error: (errresp: HttpErrorResponse) => {
        //console.log(errresp)
        this.errorMessage = errresp.message
      },
      complete: () => {
        //console.log("operation completed")
      }
    };
    const result: Observable<ProductModel[]> = this._ps.getProducts();
    result.subscribe(observerObj);
  }
  fetchProduct(id: number) {
    const observerObj: Observer<ProductModel> = {
      next: (data: ProductModel) => {
        this.selectedProduct = data
      },
      error: (errresp: HttpErrorResponse) => {
        //console.log(errresp)
        this.errorMessage = errresp.message
      },
      complete: () => {
        //console.log("operation completed")
      }
    };
    const dataObs: Observable<ProductModel> = this._ps.getProduct(id);
    dataObs.subscribe(observerObj);
  }
}
