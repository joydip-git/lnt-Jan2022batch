import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map, Observable } from "rxjs";
import { Post } from "../models/post";

@Injectable()
export class UserPostsService {

    url = 'https://jsonplaceholder.typicode.com/posts'

    constructor(private _http: HttpClient) {

    }

    public getPostByUserId(uid: number): Observable<Post[]> {
        const observableResponse = this._http.get(this.url)
        const observablePosts = observableResponse.pipe(
            map(jsonPosts => <Post[]>jsonPosts)
        )
        return observablePosts.pipe(
            map(postArray => postArray.filter(p => p.userId === uid))
        )
    }
}