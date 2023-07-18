import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { BehaviorSubject } from "rxjs";

@Injectable({
    providedIn: "root"
})
export class SampleService {

    sharedData: BehaviorSubject<string> = new BehaviorSubject<string>('');

    constructor(private http: HttpClient) { }

    getSampleData() {
        return this.http.get("https://pokeapi.co/api/v2/berry/1");
    }
}