import { NgModule } from "@angular/core";
import { Route, RouterModule } from "@angular/router";
import { SampleComponent } from "./sample.component";

const routes: Route[] = [
    {
        path: '',
        component: SampleComponent,
        title: "Sample"
    }
];

@NgModule({
    imports: [ RouterModule.forChild(routes) ],
    exports: [ RouterModule ]
})
export class SampleRoutingModule { }