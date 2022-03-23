import { Component, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import {  ClaimComponent} from "../claim/claim.component";


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor() { }
   

  ngOnInit(): void {
  }

}
