import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { Post } from "../models/post";
import { UserPostsService } from "./user-posts.service";

@Component({
    templateUrl: './user-posts.component.html'
})
export class UserPostsComponent implements OnInit {

    posts: Post[] | undefined;

    constructor(private _route: ActivatedRoute, private _postsSvc: UserPostsService, private _router: Router) {

    }
    ngOnInit() {
        const userid = Number(this._route.snapshot.params['userid'])
        const observablePosts = this._postsSvc.getPostByUserId(userid)
        observablePosts.subscribe(
            (data) => {
                this.posts = data
            }
        )
    }
    goBack() {
        this._router.navigate(['/users'])
    }
}