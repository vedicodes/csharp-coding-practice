import { NgModule, ErrorHandler } from "@angular/core";

class MyErrorHandler implements ErrorHandler {
    handleError(error: any): void {
        console.warn("Handled by custom error handler.");
        console.table(error);
    }
}

@NgModule({
    providers: [
        {
            provide: ErrorHandler,
            useClass: MyErrorHandler
        }
    ]
})
export class MyErrorHandlerModule { }