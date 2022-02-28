import { NgModule } from '@angular/core';
import { Route, RouterModule, Routes } from '@angular/router';
import { AnotherComponent } from './another/another.component';
import { SomeComponent } from './some/some.component';


const someRoute: Route = { path: 'some/:data', component: SomeComponent }
//data=>route parameter
// another/:data=> route pattern for passing data
const anotherRoute: Route = { path: 'another/:data1/:data2', component: AnotherComponent }

const otherRoutes: Routes = [anotherRoute, someRoute]
@NgModule({
    imports: [RouterModule.forRoot(otherRoutes)],
    exports: [RouterModule],
})
export class OtherRoutingModule { }
