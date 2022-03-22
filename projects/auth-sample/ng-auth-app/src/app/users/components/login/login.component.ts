import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, ActivatedRouteSnapshot, Router } from '@angular/router';
import { TokenInfo } from '../../models/tokeinfo';
import { UserInfo } from '../../models/userinfo';
import { UserService } from '../../services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginFrm: FormGroup;
  constructor(private userSvc: UserService, private activatedRoute: ActivatedRoute, private router: Router) {
    this.loginFrm = new FormGroup({
      userName: new FormControl(''),
      password: new FormControl('')
    })
  }

  ngOnInit(): void {
  }

  submitUser() {
    const userData: UserInfo = <UserInfo>this.loginFrm.value;
    //console.log(userData);
    this.userSvc
      .authenticateUser(userData)
      .subscribe({
        next: (data: TokenInfo) => sessionStorage.setItem('token', data.token),
        error: (err) => console.log(err),
        complete: () => {
          if (this.activatedRoute.snapshot.queryParams['returnUrl']) {
            const returnUrl = this.activatedRoute.snapshot.queryParams['returnUrl']
            this.router.navigate([returnUrl])
          } else {
            this.router.navigate(['/dashboard'])
          }
        }
      });
  }
}
