import { Component, OnInit } from '@angular/core';
import { NgRedux, select } from '@angular-redux/store';
import { ILoanState } from '../../store/loan-store';
import { LoanService } from '../../services/loan.service';
import { LoanActions } from '../../action/loan-action';
import { ILoanDetailsModel } from '../../models/loan-model';

@Component({
  selector: 'app-loan-header',
  templateUrl: './loan-header.component.html',
  styleUrls: ['./loan-header.component.css']
})
export class LoanHeaderComponent implements OnInit {
  @select('totalPayoutCarryOverAmount') totalPayoutCarryOverAmount;
  private loanDetailList: ILoanDetailsModel[];

  constructor(private ngRedux: NgRedux<ILoanState>,
    private loanService: LoanService) {
  }

  ngOnInit() {
    console.log('ngOnInit');
    this.loanService.getLoanDetails()
      .subscribe(result => {
        this.loanDetailList = result;
        this.ngRedux.dispatch({ type: LoanActions.getLoanDetails, todo: this.loanDetailList });
      });
  }
}
