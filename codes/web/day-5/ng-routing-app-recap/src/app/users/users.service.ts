import { User } from "../models/user";
//HttpClient: built-in service class, which helps you to perform http requests, such as fetching data, saving data, updating data, deleting data
//to use this class, from your service class, ask for dependency injection
import { HttpClient } from "@angular/common/http";
//Reactive Extension to JavaSctipt (RxJS)
import { map, Observable } from "rxjs";
import { Injectable } from "@angular/core";

//in your service class, if you are asking for dependency injection of another service (built-in or custom service), you MUST decorate this service class with @Injectable()

@Injectable()
export class UsersService {
    private url: string = 'https://jsonplaceholder.typicode.com/users'

    constructor(private _http: HttpClient) {

    }

    public getUsers(): Observable<User[]> {
        const observableResponse = this._http.get(this.url)
        const observableUsersArray = observableResponse.pipe(map(jsonArray => <User[]>jsonArray))
        return observableUsersArray;
    }
    public getUserById(id: number): Observable<User> {
        const observableResponse = this._http.get(`${this.url}/${id}`)
        const observableUser = observableResponse.pipe(map(jsonObject => <User>jsonObject))
        return observableUser
    }
}