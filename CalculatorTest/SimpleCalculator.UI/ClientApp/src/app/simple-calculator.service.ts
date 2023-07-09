import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SimpleCalculatorService {
  add(start: number, amount: number) {
    return start + amount;
  }

  subtract(start: number, amount: number) {
    return start - amount;
  }

  constructor() {
  }
}
