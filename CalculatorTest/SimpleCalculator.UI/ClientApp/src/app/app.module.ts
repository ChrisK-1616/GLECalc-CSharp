import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { SimpleCalculatorComponent } from './simple-calculator/simple-calculator.component';
import { SimpleCalculatorService } from './simple-calculator.service';

@NgModule({
  declarations: [
    AppComponent,
    SimpleCalculatorComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([])
  ],
  providers: [
    SimpleCalculatorService,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
