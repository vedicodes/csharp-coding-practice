import { HttpEvent, HttpHandler, HttpHeaders, HttpInterceptor, HttpRequest } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable()
export class MyCustomInterceptor implements HttpInterceptor {

    headers: HttpHeaders = new HttpHeaders();

    constructor() {
        this.headers = this.headers.append("Accept-Language", "en-US,en;q=0.5")
        .append("X-Checked", "Interceptor");
    }

    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        var clonedReq = req.clone({
            headers: this.headers
        });
        return next.handle(clonedReq);
    }
}