import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { environment } from '../../../environments/environment';

@Injectable()
export class ApiService {
    constructor(
        private http: HttpClient,
    ) { }

    get<T>(path: string, params: HttpParams = new HttpParams()): Promise<T> {
        return this.http.get<T>(`${environment.apiUrl}${path}`, { params }).toPromise();
    }

    put<T>(path: string, body: Object = {}): Promise<T> {
        return this.http.put<T>(
            `${environment.apiUrl}${path}`, body
        ).toPromise();
    }

    post<T>(path: string, body: Object = {}): Promise<T> {
        return this.http.post<T>(
            `${environment.apiUrl}${path}`, body
        ).toPromise();
    }

    delete<T>(path): Promise<T> {
        return this.http.delete<T>(
            `${environment.apiUrl}${path}`
        ).toPromise();
    }
}
