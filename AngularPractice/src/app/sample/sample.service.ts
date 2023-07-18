import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";

@Injectable({
    providedIn: "root"
})
export class SampleService {

    headers: HttpHeaders = new HttpHeaders();

    constructor(private http: HttpClient) {
        this.headers = this.headers.append("Accept-Language", "en-US,en;q=0.5");
    }

    getSampleData() {
        return this.http.get("https://pokeapi.co/api/v2/berry/1",{
            headers: this.headers
        });
    }
}