import { NgModule } from '@angular/core';
import { ConcertComponent } from './concert.component';
import { AddConcertComponent } from './add-concerts/add-concert.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { DisplayConcertsComponent } from './display-concerts/display-concerts.component';
import { CentricMatInputModule, CentricSelectModule } from '@centric/ng-styleguide';

@NgModule({
  declarations: [
    ConcertComponent, 
    AddConcertComponent, 
    DisplayConcertsComponent],
  imports: [
    FormsModule,
    ReactiveFormsModule,
    CommonModule,
    CentricMatInputModule,
    CentricSelectModule 
  ],
  providers: [],
})
export class ConcertModule { }
