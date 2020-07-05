import { NgModule } from '@angular/core';
import { ConcertComponent } from './concert.component';
import { AddConcertComponent } from './add-concerts/add-concert.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import {MatSelectModule} from '@angular/material/select';

@NgModule({
  declarations: [ConcertComponent, AddConcertComponent],
  imports: [FormsModule,
    ReactiveFormsModule,CommonModule,MatSelectModule
  ],
  providers: [],
})
export class ConcertModule { }
