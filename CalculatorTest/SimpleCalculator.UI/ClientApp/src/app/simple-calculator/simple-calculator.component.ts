import { Component, OnInit } from '@angular/core';
import { SimpleCalculatorService } from '../simple-calculator.service';

@Component({
  selector: 'simple-calculator',
  templateUrl: './simple-calculator.component.html',
  styleUrls: ['./simple-calculator.component.css']
})
export class SimpleCalculatorComponent implements OnInit {
  arithService: SimpleCalculatorService;

  constructor(service: SimpleCalculatorService) {
    this.arithService = service;
  }

  ngOnInit() {
  }
}
