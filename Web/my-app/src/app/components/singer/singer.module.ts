import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SingerComponent } from './singer.component';
import { AddSingerComponent } from './add-singer/add-singer.component';
import { 
  CentricMatInputModule, 
  CentricButtonModule, 
  CentricPaginatorModule, 
  CentricPanelModule,
  CentricDataGridModule, 
  CentricFormModule } from '@centric/ng-styleguide';

@NgModule({
  declarations: [
    SingerComponent, 
    AddSingerComponent
  ],
  imports: [
    FormsModule,
    ReactiveFormsModule,
    CentricMatInputModule,
    CentricButtonModule,
    CentricPaginatorModule,
    CentricPanelModule,
    CentricDataGridModule,
    CentricFormModule 
  ],
  providers: [],
})
export class SingerModule { }
