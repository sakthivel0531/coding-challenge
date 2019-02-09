import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoanHeaderComponent } from './modules/loan-management/components/loan-header/loan-header.component';
import { LoanSubHeaderComponent } from './modules/loan-management/components/loan-sub-header/loan-sub-header.component';
import { LoanDetailsComponent } from './modules/loan-management/components/loan-details/loan-details.component';

@NgModule({
  declarations: [
    AppComponent,
    LoanHeaderComponent,
    LoanSubHeaderComponent,
    LoanDetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
