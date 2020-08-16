import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { LocationService } from 'src/app/components/location/location.service';
import { Location } from '../location.model';

@Component({
  selector: 'app-add-location',
  templateUrl: './add-location.component.html',
  styleUrls: ['./add-location.component.scss']
})
export class AddLocationComponent implements OnInit {
  locationForm: FormGroup;
  location = new Location();

  get isSubmitButtonDisabled(): boolean {
    return !this.locationForm.valid;
  }

  constructor(public locationService: LocationService) { }

  ngOnInit(): void {
    this.initForm();
  }

  isFieldInvalid(name: string): boolean {
    const control = this.locationForm.get(name);
    return (control.dirty && control.touched) ? control.invalid : false;
  }

  getErrorMessage(control: string): string {
    if (this.locationForm.get(control).hasError('required') && this.locationForm.get(control).touched) {
      return 'This field is required';
    }
  }

  submit(): void {
    if (this.locationForm.valid) {
      this.location.country = this.locationForm.get('country').value;
      this.location.county = this.locationForm.get('county').value;
      this.location.name = this.locationForm.get('name').value;
      this.location.street = this.locationForm.get('street').value;

      this.locationService.add(this.location).subscribe();
    }
  }

  private initForm(): void {
    this.locationForm = new FormGroup({
      country: new FormControl('', [Validators.required]),
      county: new FormControl('', [Validators.required]),
      name: new FormControl('', [Validators.required]),
      street: new FormControl('', [Validators.required]),
    })
  }
}
