import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BaseService {
  public enviroment = 'https://localhost:44304/api/';
  constructor(private http: HttpClient) { }

  public post<T>(url: string, data: T): Observable<T> {
    const completeUrl: string = this.enviroment + url;
    return this.http.post<T>(completeUrl, data );
  }

  public get<T>(url: string): Observable<T> {
    const completeUrl: string = this.enviroment + url;
    return this.http.get<T>(completeUrl);
  }
}