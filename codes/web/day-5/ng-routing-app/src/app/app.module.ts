import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { Route, Routes, RouterModule } from "@angular/router";

import { AnotherComponent } from './another/another.component';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { IndexComponent } from './index/index.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { SomeComponent } from './some/some.component';

//creating individual routes of type Route
const homeRoute: Route = { path: 'home', component: HomeComponent }
const defaultRoute: Route = { path: '', redirectTo: '/home', pathMatch: 'full' }
const someRoute: Route = { path: 'some', component: SomeComponent }
const anotherRoute: Route = { path: 'another', component: AnotherComponent }
const pageNotFoundRoute: Route = { path: '**', component: PageNotFoundComponent }

//storing the routes in an array of data type Routes
//page not found route should be mentioned last in the array
const appRoutes: Routes = [defaultRoute, homeRoute, someRoute, anotherRoute, pageNotFoundRoute]

@NgModule({
  declarations: [
    AppComponent, IndexComponent, SomeComponent, AnotherComponent, PageNotFoundComponent, HomeComponent
  ],
  imports: [
    BrowserModule,
    //registering the routes with RouterModule
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
