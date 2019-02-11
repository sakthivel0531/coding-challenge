import { Component, OnInit, Input, ViewChild, ElementRef } from '@angular/core';
import { ILoanDetailsModel } from 'coding-challenge/LoanUI/src/app/modules/loan-management/models/loan-model';
import { NgRedux } from '@angular-redux/store';
import { ILoanState } from 'coding-challenge/LoanUI/src/app/modules/loan-management/store/loan-store';
import { LoanActions } from 'coding-challenge/LoanUI/src/app/modules/loan-management/action/loan-action';

@Component({
  selector: 'app-loan-details',
  templateUrl: './loan-details.component.html',
  styleUrls: ['./loan-details.component.css']
})
export class LoanDetailsComponent implements OnInit {
  @Input() LoanDetail: ILoanDetailsModel;
  @Input() SerialNo: number;
  topUpValue = false;
  payoutCarryOverAmountElement: number;

  constructor(private ngRedux: NgRedux<ILoanState>) {
  }

  ngOnInit() {

  }

  topUpChange(event) {
    console.log(this.LoanDetail.payoutCarryOverAmount);
    if (event.target.checked) {
      this.ngRedux.dispatch({ type: LoanActions.addPayoutCarryOverAmount, todo: this.LoanDetail.payoutCarryOverAmount });
    } else {
      this.ngRedux.dispatch({ type: LoanActions.minusPayoutCarryOverAmount, todo: this.LoanDetail.payoutCarryOverAmount });
    }
    this.topUpValue = event.target.checked;
  }

}
