import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HttpClient } from '@angular/common/http'
import { AppComponent } from './app.component';
import { ValueComponent } from './value/value.component';

@NgModule({
  declarations: [
    AppComponent,
      ValueComponent
   ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
