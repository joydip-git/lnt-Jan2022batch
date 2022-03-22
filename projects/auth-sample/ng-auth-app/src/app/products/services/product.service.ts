import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, map } from 'rxjs';
import { Product } from '../models/product';

@Injectable()
export class ProductService {
  private url = 'http://localhost:45876/api/product'
  constructor(private _http: HttpClient) { }
  public fetchProducts(): Observable<Product[]> {
    //return this._http.get(this.url).pipe(map(resp => <Product[]>resp));
    return this._http.get<Product[]>(this.url);
  }
}
