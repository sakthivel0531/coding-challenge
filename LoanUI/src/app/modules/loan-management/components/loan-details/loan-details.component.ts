import { Component, OnInit, Input, ViewChild, ElementRef } from '@angular/core';
import { NgRedux } from '@angular-redux/store';
import { ILoanDetailsModel } from '../../models/loan-model';
import { ILoanState } from '../../store/loan-store';
import { LoanActions } from '../../action/loan-action';


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
    if (event.target.checked) {
      this.ngRedux.dispatch({ type: LoanActions.addPayoutCarryOverAmount, todo: this.LoanDetail.payoutCarryOverAmount });
    } else {
      this.ngRedux.dispatch({ type: LoanActions.minusPayoutCarryOverAmount, todo: this.LoanDetail.payoutCarryOverAmount });
    }
    this.topUpValue = event.target.checked;
  }

}
