import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map, Observable, Observer } from "rxjs";
import { ProductModel } from "../models/product";
import { environment } from '../../environments/environment'

//since you are asking angular dependency injector to create an instance of HttpClient class and inject the reference of the object to the constructor of the ProductService class. the reference of HttpClient class object will be stored in private data member _http.
@Injectable()
export class ProductService {
    private url = environment.apiUrl;

    constructor(private _http: HttpClient) {

    }
    public getProducts(): Observable<ProductModel[]> {
        //making request using HTTP protocol's GET method to the given RESTful API
        //the method makes an asynchronous request to the RESTful API
        //hence the method returns an Observable class object which waits for the response
        //here entire response body as JSON object is stored in that Observable object (when the response arrives)
        //response might contain proper data or an error
        const responseObs: Observable<any> = this._http.get(this.url);
        //tell the observer what to do with the response present insie it, when the response arrives
        //for that you create an observer object with logic for what to do 
        //i.in case of proper response, 
        //ii.in case of an error 
        //ii.after next callback is successfully executed, what to do after that
        //subscribe method of Observable will call either "next" or "error" callback based on the siruation and then afterwards will the "complete" callback
        //when subscribe method calls the "next" callback, it passes the response to the next callback as argument
        //when subscribe method calls the "error" callback, it passes the error response to the error callback as argument
        //complete callback does not accept any argument
        // const observerObj: Observer<ProductModel[]> = {
        //     next: (products: ProductModel[]) => { console.log(products) },
        //     error: (errresp: any) => { console.log(errresp) },
        //     complete: () => { console.log("operation completed") }
        // };

        //arry's map method
        // const arr = [1, 2, 3, 4, 5];
        // const modified = arr.map(function (num: number) {
        //     return num * 5;
        // });
        //console.log(modified)

        //map the response data (JSON object array) to ProductModel array type (an array of ProductModel objects)
        //use map() function of rxjs package
        const convertLogic = map((responseJsonArray: any) => <ProductModel[]>responseJsonArray);
        const productsObs: Observable<ProductModel[]> = responseObs.pipe(convertLogic);
        return productsObs;
        //productsObs.subscribe(observerObj);
    }
    public getProduct(id: number): Observable<ProductModel> {
        //this._http.get(this.url + '/' + id);
        const responseObs: Observable<any> = this._http.get(`${this.url}/${id}`)
        const productModelObs = responseObs.pipe(
            map(
                function (data: any) {
                    return <ProductModel>data;
                }
            )
        );
        return productModelObs;
    }
}