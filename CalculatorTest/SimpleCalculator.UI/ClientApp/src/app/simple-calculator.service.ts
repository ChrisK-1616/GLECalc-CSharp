import { HttpClient, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SimpleCalculatorService {
  constructor(private http: HttpClient) {
  }

  add(start: number, amount: number): Observable<number> {
    let url: string = `http://localhost:5000/api/SimpleCalculator/Add?start=${start}&amount=${amount}`;

    return this.http.get<number>(url);
  }

  subtract(start: number, amount: number): Observable<number> {
    let url: string = `http://localhost:5000/api/SimpleCalculator/Subtract?start=${start}&amount=${amount}`;

    return this.http.get<number>(url);
  }
}
