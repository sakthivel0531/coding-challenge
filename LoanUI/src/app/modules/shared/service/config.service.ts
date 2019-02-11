
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class ConfigService {

    configUrl = 'assets/config.json';
    constructor(private http: HttpClient) {

    }

    public getApiUrl(): string {
        let apiUrl = '';
        this.getConfigValue()
            .subscribe(data => {
                apiUrl = data['apiUrl']
            });
        return apiUrl;
    }

    private getConfigValue() {
        return this.http.get(this.configUrl);
    }

}
