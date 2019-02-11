import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoanHeaderComponent } from './modules/loan-management/components/loan-header/loan-header.component';
import { LoanSubHeaderComponent } from './modules/loan-management/components/loan-sub-header/loan-sub-header.component';
import { LoanDetailsComponent } from './modules/loan-management/components/loan-details/loan-details.component';
import { RouterModule } from '@angular/router';
import { NgRedux, NgReduxModule } from '@angular-redux/store';
import { ILoanState, INITIAL_LOAN_STATE } from './modules/loan-management/store/loan-store';
import { rootReducer } from './modules/loan-management/reducer/loan-reducer';
import { HttpClientModule } from '@angular/common/http';
import { LoanService } from './modules/loan-management/services/loan.service';
import { FormsModule } from '@angular/forms';
import { ConfigService } from './modules/shared/service/config.service';

@NgModule({
  declarations: [
    AppComponent,
    LoanHeaderComponent,
    LoanSubHeaderComponent,
    LoanDetailsComponent
  ],
  imports: [
    RouterModule.forRoot(
      [
        {
          path: '',
          redirectTo: '/loan',
          pathMatch: 'full'
        },
        {
          path: 'loan',
          component: LoanHeaderComponent
        }
      ]
    ),
    BrowserModule,
    AppRoutingModule,
    NgReduxModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [
    LoanService,
    ConfigService
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
  constructor(ngRedux: NgRedux<ILoanState>) {
    ngRedux.configureStore(rootReducer, INITIAL_LOAN_STATE);
  }
}
