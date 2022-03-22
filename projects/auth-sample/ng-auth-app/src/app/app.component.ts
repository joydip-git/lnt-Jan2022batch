import { Component, OnChanges, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from './core/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  isLogged = false;
  constructor(private authSvc: AuthService, private router: Router) {

  }

  ngOnInit(): void {
    this.isLogged = this.authSvc.isLoggedIn()
  }
  logout() {
    this.authSvc.logout();
    this.isLogged = false
    this.router.navigate(['/login'])
  }
}
