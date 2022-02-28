import { NgModule } from '@angular/core';
import { Route, RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { UserPostsComponent } from './user-posts/user-posts.component';
import { UsersComponent } from './users/users.component';

const userPostsRoute: Route = { path: 'users/:userid/posts', component: UserPostsComponent }
const usersRoute: Route = { path: 'users', component: UsersComponent }
const homeRoute: Route = { path: 'home', component: HomeComponent }
const defaultPath: Route = { path: '', redirectTo: '/home', pathMatch: 'full' }
const wrongRoute: Route = { path: '**', component: PageNotFoundComponent }

const routes: Routes = [usersRoute, userPostsRoute, homeRoute, defaultPath, wrongRoute];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
