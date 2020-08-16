import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { ConcertComponent } from './concert.component';
import { AddConcertComponent } from './add-concerts/add-concert.component';
import { DisplayConcertsComponent } from './display-concerts/display-concerts.component';
import { 
  CentricMatInputModule, 
  CentricSelectModule, 
  CentricFormModule, 
  CentricButtonModule, 
  CentricPaginatorModule,
   CentricPanelModule, 
   CentricDataGridModule } from '@centric/ng-styleguide';

@NgModule({
  declarations: [
    ConcertComponent, 
    AddConcertComponent, 
    DisplayConcertsComponent
  ],
  imports: [
    FormsModule,
    ReactiveFormsModule,
    CentricFormModule,
    CommonModule,
    CentricMatInputModule,
    CentricSelectModule,
    CentricButtonModule,
    CentricPaginatorModule,
    CentricPanelModule,
    CentricDataGridModule 
  ],
  providers: [],
}) 
export class ConcertModule { }
