import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { UserPostsComponent } from './user-posts/user-posts.component';
import { UserPostsService } from './user-posts/user-posts.service';
import { UsersComponent } from './users/users.component';
import { UsersService } from './users/users.service';

@NgModule({
  declarations: [
    AppComponent, UsersComponent, HomeComponent, PageNotFoundComponent, UserPostsComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [UsersService, UserPostsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
