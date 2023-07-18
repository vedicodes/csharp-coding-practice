import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { MyErrorHandlerModule } from './error-handler/error-handler';
import { httpInterceptorProviders } from './http-interceptor/';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    MyErrorHandlerModule
  ],
  providers: [ 
    httpInterceptorProviders
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
