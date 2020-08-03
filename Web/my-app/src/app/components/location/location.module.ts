import { NgModule } from '@angular/core';
import { LocationComponent } from './location.component';
import { AddLocationComponent } from './add-location/add-location.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CentricMatInputModule } from '@centric/ng-styleguide';

@NgModule({
  declarations: [
    LocationComponent, 
    AddLocationComponent
  ],
  imports: [
    FormsModule,
    ReactiveFormsModule,    
    CentricMatInputModule,
  ],
  providers: [],
})
export class LocationModule { }
