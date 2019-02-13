import { Component, OnInit } from '@angular/core';
import { select, NgRedux } from '@angular-redux/store';
import { LoanSettings } from '../../action/loan-action';
import { ILoanState } from '../../store/loan-store';

@Component({
  selector: 'app-loan-sub-header',
  templateUrl: './loan-sub-header.component.html',
  styleUrls: ['./loan-sub-header.component.css']
})
export class LoanSubHeaderComponent implements OnInit {

  @select('totalLoan') totalLoan;
  @select('loanDetailList') loanDetailList;
  public maxNumberOfLoans: number = LoanSettings.maxNumberOfLoans;

  constructor(private ngRedux: NgRedux<(ILoanState)>) {

  }

  ngOnInit() {

  }

}
