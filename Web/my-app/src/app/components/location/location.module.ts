import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { LocationComponent } from './location.component';
import { AddLocationComponent } from './add-location/add-location.component';
import { 
  CentricMatInputModule, 
  CentricButtonModule,
  CentricPaginatorModule, 
  CentricPanelModule, 
  CentricDataGridModule,
   CentricFormModule } from '@centric/ng-styleguide';

@NgModule({
  declarations: [
    LocationComponent, 
    AddLocationComponent
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
export class LocationModule { }
