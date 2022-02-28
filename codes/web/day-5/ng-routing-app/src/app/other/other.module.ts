import { NgModule } from '@angular/core';
import { AnotherComponent } from './another/another.component';
import { OtherRoutingModule } from './other-routing.module';
import { SomeComponent } from './some/some.component';


@NgModule({
    imports: [OtherRoutingModule],
    exports: [],
    declarations: [SomeComponent, AnotherComponent],
    providers: [],
})
export class OtherModule { }
