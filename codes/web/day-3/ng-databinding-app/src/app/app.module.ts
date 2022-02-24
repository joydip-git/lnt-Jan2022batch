import { NgModule } from "@angular/core";
import { AppComponent } from "./app.component";
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule } from "@angular/forms";

@NgModule({
  /** register the names of components, pipes and directives in the array of 'declarations' property */
  declarations: [AppComponent],
  /** register the names of other modules in the array of 'imports' property */
  /**BrowserModule is the one which brings all assets required to run the Angular app in the browser. Register it in the root module only */
  imports: [BrowserModule, FormsModule],
  /** register the names of services in the array of 'providers' property */
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
  constructor() {
    console.log('App module object created')
  }
}
