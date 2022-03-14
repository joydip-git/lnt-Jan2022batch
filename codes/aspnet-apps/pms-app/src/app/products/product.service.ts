import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { map, Observable } from 'rxjs';
import { Product } from '../models/Product';

@Injectable()
export class ProductService {

  private url = "http://localhost:56177/productsapi/Products";

  constructor(private _http: HttpClient) {
    console.log("service created...")
  }
  public getAllProducts(): Observable<Product[]> {
    //an observable object containing JSON array of products as response
    const respObject = this._http.get(this.url);
    //convert the response (JSON array) to an array of Product type objects
    const mappedObservable: Observable<Product[]> =
      respObject.pipe(map(arr => {
        console.log(arr)
        return <Product[]>arr
      }));
    return mappedObservable;
  }
}
