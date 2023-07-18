import { Component, OnInit } from "@angular/core";
import { SampleService } from "./sample.service";
import { Observable } from "rxjs";

@Component({
    selector: "sample",
    templateUrl: "./sample.component.html",
    styleUrls: [ "./sample.component.scss" ]
})
export class SampleComponent implements OnInit {

    data$: Observable<Object>;
    sharedData$: Observable<string>;

    constructor(private sampleService: SampleService) {
        this.data$ = sampleService.getSampleData();
        this.sharedData$ = sampleService.sharedData.asObservable();
    }

    ngOnInit(): void {
        throw Error("Manual Error!");
    }

}