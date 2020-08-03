import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ConcertService } from 'src/app/components/concert/concert.service';
import { Concert } from 'src/app/components/concert/concert.model';
import { LocationService } from '../../location/location.service';
import { SingerService } from '../../singer/singer.service';
import { forkJoin } from 'rxjs';
import { Singer } from '../../singer/singer.model';
import { Location } from '../../location/location.model';

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

  constructor (
    public concertService: ConcertService, 
    public locationService: LocationService,
    public singerService: SingerService) 
    { }

  ngOnInit(): void {
    this.loadData();
    this.initForm();
  }

  isFieldInvalid(control: string): boolean {
    return this.concertForm.get(control).invalid && this.concertForm.get(control).touched;
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
  }
}
