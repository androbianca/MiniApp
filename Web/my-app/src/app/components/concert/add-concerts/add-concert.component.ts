import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { forkJoin } from 'rxjs';
import { ConcertService } from 'src/app/components/concert/concert.service';
import { Concert } from 'src/app/components/concert/concert.model';
import { LocationService } from 'src/app/shared/services/location.service';
import { SingerService } from 'src/app/shared/services/singer.service';
import { Singer } from '../../../shared/models/singer.model';
import { Location } from '../../../shared/models/location.model';

@Component({
  selector: 'app-add-concert',
  templateUrl: './add-concert.component.html',
  styleUrls: ['./add-concert.component.scss']
})
export class AddConcertComponent implements OnInit {
  concertForm: FormGroup;
  concert = new Concert();
  locations: Location[] = [];
  singers: Singer[] = [];

  get isSubmitButtonDisabled(): boolean {
    return !this.concertForm.valid;
  }

  constructor(
    public concertService: ConcertService, 
    public locationService: LocationService,
    public singerService: SingerService) { }

  ngOnInit(): void {
    this.loadData();
    this.initForm();
  }

  isFieldInvalid(name: string): boolean {
    const control = this.concertForm.get(name);
    return (control.dirty && control.touched) ? control.invalid : false;
  }

  getErrorMessage(control: string): string {
    if(this.concertForm.get(control).hasError('required') && this.concertForm.get(control).touched) {
      return 'This field is required';
    }
  }

  openedChanged(control: string): void {
    this.concertForm.get(control).markAsTouched();
  }

  submit(): void {
    this.concertForm.markAllAsTouched();
    
    if(this.concertForm.valid) {
      this.concert.name = this.concertForm.get('name').value;
      this.concert.price = +this.concertForm.get('price').value;
      this.concert.locationId = this.concertForm.get('location').value;
      this.concert.singerId = this.concertForm.get('singer').value;
  
      this.concertService.add(this.concert).subscribe();
    }
  }

  private loadData(): void {
    forkJoin({
      locations: this.locationService.getAll(),
      singers: this.singerService.getAll(),
    })
      .subscribe(({ locations, singers }) => {
        this.locations = locations;
        this.singers = singers;
      });
  }

  private initForm(): void {
    this.concertForm = new FormGroup({
      name: new FormControl('', [Validators.required]),
      price: new FormControl('', [Validators.required]),
      location: new FormControl('', [Validators.required]),
      singer: new FormControl('', [Validators.required])
    })

    this.concertForm.valueChanges.subscribe(x => console.log(x))
  }
}
