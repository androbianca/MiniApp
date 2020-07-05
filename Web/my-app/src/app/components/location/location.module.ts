import { NgModule } from '@angular/core';
import { LocationComponent } from './location.component';
import { AddLocationComponent } from './add-location/add-location.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [LocationComponent, AddLocationComponent],
  imports: [FormsModule,
    ReactiveFormsModule],
  providers: [],
})
export class LocationModule { }
