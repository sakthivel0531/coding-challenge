import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { ILoanDetailsModel } from '../models/loan-model';
import { ConfigService } from '../../shared/service/config.service';

@Injectable()
export class LoanService {

    constructor(private http: HttpClient,
                private configService: ConfigService) {
    }

    public getLoanDetails(): Observable<ILoanDetailsModel[]> {
        // const apiUrl = this.configService.getApiUrl(); // For some reason this approach doesn't work, hence, hardcoding it.
        const apiUrl = 'http://localhost:5000/api/loan/GetAllLoanDetails';
        const result = this.http.get<ILoanDetailsModel[]>(apiUrl);
        return result;
    }
}
