import { Component, OnInit } from '@angular/core';
import { SimpleCalculatorService } from '../simple-calculator.service';

@Component({
  selector: 'simple-calculator',
  templateUrl: './simple-calculator.component.html',
  styleUrls: ['./simple-calculator.component.css']
})
export class SimpleCalculatorComponent {
  start: number = 0;
  amount: number = 0;
  result: number = 0;
  isOrange: boolean = true; 
  
  constructor(public arithService: SimpleCalculatorService) {
  }

  onAdd() {
    this.arithService.add(this.start, this.amount).
      subscribe(response  => {
        this.result = response.valueOf();
      });
  }

  onSubtract() {
    this.arithService.subtract(this.start, this.amount).
      subscribe(response => {
        this.result = response.valueOf();
      });
  }

  onBgColourOrange() {
    this.isOrange= true; 
  }

  onBgColourSalmon() {
    this.isOrange = false; 
  }
}
