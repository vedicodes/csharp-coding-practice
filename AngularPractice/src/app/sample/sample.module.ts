import { NgModule } from "@angular/core";
import { SampleComponent } from "./sample.component";
import { CommonModule } from "@angular/common";
import { SampleRoutingModule } from "./sample-routing.module";

@NgModule({
    declarations: [ SampleComponent ],
    imports: [ 
        CommonModule,
        SampleRoutingModule 
    ],
    exports: [ SampleComponent ]
})
export class SampleModule { }