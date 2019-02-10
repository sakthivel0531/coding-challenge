import { Component, OnInit, Input } from '@angular/core';
import { ILoanDetailsModel } from 'coding-challenge/LoanUI/src/app/modules/loan-management/models/loan-model';

@Component({
  selector: 'app-loan-details',
  templateUrl: './loan-details.component.html',
  styleUrls: ['./loan-details.component.css']
})
export class LoanDetailsComponent implements OnInit {

  @Input() LoanDetail: ILoanDetailsModel;
  serialNo = 0;
  topUpValue = false;


  constructor() { }

  ngOnInit() {
    this.serialNo = this.serialNo + 1;
  }

  topUpChange(event) {
    this.topUpValue = event.target.checked;
  }

}
