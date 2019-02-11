import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { ILoanDetailsModel } from '../models/loan-model';
import { map, catchError } from 'rxjs/operators';

@Injectable()
export class LoanService {

    constructor(private http: HttpClient) {
    }

    public getLoanDetails(): Observable<ILoanDetailsModel[]> {
        const url = 'http://localhost:5000/api/loan/GetAllLoanDetails';
        const result = this.http.get<ILoanDetailsModel[]>(url);
        return result;
    }
}
