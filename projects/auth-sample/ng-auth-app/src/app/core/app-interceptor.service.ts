import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AuthService } from './auth.service';

@Injectable()
export class AppInterceptorService implements HttpInterceptor {

  constructor(private authSvc: AuthService) { }
  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    const reqWithToken = req.clone({
      setHeaders: {
        Authorization: `Bearer ${this.authSvc.getToken()}`
      }
    })
    return next.handle(reqWithToken);
  }
}
