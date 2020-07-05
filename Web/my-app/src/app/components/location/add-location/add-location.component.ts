import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { LocationService } from 'src/app/components/location/location.service';
import { Location } from '../location.model';

@Component({
  selector: 'app-add-location',
  templateUrl: './add-location.component.html',
  styleUrls: ['./add-location.component.scss']
})
export class AddLocationComponent implements OnInit {

  locationForm: FormGroup;
  location= new Location();
  
  constructor(public locationService:LocationService) { }

  ngOnInit(): void {
    this.initForm();
  }

  initForm(): void {
    this.locationForm = new FormGroup({
      country: new FormControl(''),
      county: new FormControl(''),
      name: new FormControl(''),
      street: new FormControl(''),
    })
  }

  submit(): void {
    debugger
    this.location.country = this.locationForm.get('country').value;
    this.location.county = this.locationForm.get('county').value;
    this.location.name = this.locationForm.get('name').value;
    this.location.street = this.locationForm.get('street').value;

    this.locationService.add(this.location).subscribe();
  }

}
