import { Component } from "@angular/core";
import { SampleService } from "./sample.service";
import { Observable } from "rxjs";

@Component({
    selector: "sample",
    templateUrl: "./sample.component.html",
    styleUrls: [ "./sample.component.scss" ]
})
export class SampleComponent {

    data$: Observable<Object>;

    constructor(private sampleService: SampleService) {
        this.data$ = sampleService.getSampleData();
    }

}