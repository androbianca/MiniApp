import { Component, Input, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Location } from '../../../shared/models/location.model';
import { LocationService } from 'src/app/shared/services/location.service';
import { DialogService } from '@centric/ng-styleguide';
import { MapComponent } from '../map/map.component';
import { Coordinates } from '../map/coordinates';

@Component({
  selector: 'app-add-location',
  templateUrl: './add-location.component.html',
  styleUrls: ['./add-location.component.scss']
})
export class AddLocationComponent implements OnInit {
  locationForm: FormGroup;
  location = new Location();
  coordinates: Coordinates;
  dialogRef: any;

  get isSubmitButtonDisabled(): boolean {
    return !this.locationForm.valid;
  }

  get latitude(): FormControl {
    return this.locationForm.get('latitude') as FormControl;
  }

  get longitude(): FormControl {
    return this.locationForm.get('longitude') as FormControl;
  }

  constructor(private locationService: LocationService, private dialogService: DialogService) { }

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
      this.location.latitude = this.latitude.value;
      this.location.longitude = this.longitude.value;

      this.locationService.add(this.location).subscribe();
    }
  }

  openModal(): void {
    this.dialogRef = this.dialogService.message(MapComponent, {
      data: {
        name: 'Map modal',
        height: 200,
        width: 200
      }
    });
    this.onModalClose();
  }

  private onModalClose(): void {
    this.dialogRef.afterClosed().subscribe((result: Coordinates) => {
      this.latitude.setValue(result.latitude.toString());
      this.longitude.setValue(result.longitude.toString());
    });
  }

  private initForm(): void {
    this.locationForm = new FormGroup({
      country: new FormControl('', [Validators.required]),
      county: new FormControl('', [Validators.required]),
      name: new FormControl('', [Validators.required]),
      street: new FormControl('', [Validators.required]),
      latitude: new FormControl('', [Validators.required]),
      longitude: new FormControl('', [Validators.required]),
    })
  }
}
