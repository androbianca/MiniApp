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
   CentricFormModule, CentricDialogModule, CentricIconModule } from '@centric/ng-styleguide';
import { MapComponent } from './map/map.component';
import { GoogleMapsModule } from '@angular/google-maps';
import { BrowserModule } from '@angular/platform-browser';

@NgModule({
  declarations: [
    LocationComponent, 
    AddLocationComponent,
    MapComponent,
  ],
  imports: [
    FormsModule,
    ReactiveFormsModule,    
    CentricMatInputModule,
    CentricButtonModule,
    CentricPaginatorModule,
    CentricPanelModule,
    CentricDataGridModule,
    CentricFormModule,
    CentricDialogModule,
    CentricButtonModule,
    GoogleMapsModule,
    BrowserModule ,
    CentricIconModule
  ],
  providers: [],
  entryComponents:[MapComponent]
})
export class LocationModule { }
