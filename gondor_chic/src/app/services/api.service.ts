import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class ApiService {

  private baseUrl = 'http://localhost:5237/api';

  constructor(private http: HttpClient) {}

  login(data: { pseudo: string; motDePasse: string }): Observable<any> {
    return this.http.post(`${this.baseUrl}/auth/login`, data);
  }

  getHome(idClient: number): Observable<any> {
    return this.http.get(`${this.baseUrl}/home/${idClient}`);
  }
}
