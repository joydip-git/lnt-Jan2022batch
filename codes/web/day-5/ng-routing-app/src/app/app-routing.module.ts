import { NgModule } from "@angular/core";
import { Route, RouterModule, Routes } from "@angular/router";
import { HomeComponent } from "./home/home.component";
import { PageNotFoundComponent } from "./page-not-found/page-not-found.component";

//creating individual routes of type Route
const homeRoute: Route = { path: 'home', component: HomeComponent }
const defaultRoute: Route = { path: '', redirectTo: '/home', pathMatch: 'full' }
const pageNotFoundRoute: Route = { path: '**', component: PageNotFoundComponent }

//storing the routes in an array of data type Routes
//page not found route should be mentioned last in the array
const appRoutes: Routes = [defaultRoute, homeRoute, pageNotFoundRoute]

@NgModule({
    imports: [
        //registering the routes with RouterModule
        RouterModule.forRoot(appRoutes)
    ],
    exports: [
        //export the re-configured RouterModule
        RouterModule
    ]
})
export class AppRoutingModule {

}