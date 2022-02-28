import { Component, OnInit } from "@angular/core";
import { User } from "../models/user";
import { UsersService } from "./users.service";

@Component({
    templateUrl: './users.component.html',
    styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {
    usersData: User[] | undefined;
    constructor(private _userSvc: UsersService) {

    }
    //init event: to handle this event, write a function 'ngOnInit' your class. this function will get called when the event gets fired
    //this event gets fired exactly after constructor and only one time during the while life cycle of this component, until destroyed
    //this ngOnInit method is declared inside OnInit interface
    //DON'T WRITE DATA FETCHING CODE IN CONSTRUCTOR. WRITE IT IN ONINIT EVENT CODE
    ngOnInit(): void {
        const observableOfUsers = this._userSvc.getUsers()
        observableOfUsers
            .subscribe(
                (usersArray) => {
                    this.usersData = usersArray
                }
            )
    }
}