import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
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
  concert= new Concert();
  locations: Location[] = [];
  singers:Singer[]= [];
  
  constructor(public concertService:ConcertService, public locationService:LocationService, public singerService: SingerService) { }

  ngOnInit(): void {
    this.loadData();
    this.initForm();

  }

  loadData() {
    forkJoin({
      locations: this.locationService.getAll(),
      singers : this.singerService.getAll(),
    })
    .subscribe(({locations,singers}) => {
      debugger
       this.locations = locations;
       this.singers= singers;
    });
  }
  
  initForm(): void {
    this.concertForm = new FormGroup({
      name: new FormControl(''),
      price: new FormControl(''),
      location: new FormControl(''),
      singer:new FormControl('')
    })
  }

  submit(): void {
    debugger
    this.concert.name = this.concertForm.get('name').value;
    this.concert.price = +this.concertForm.get('price').value;
    this.concert.locationId = this.concertForm.get('location').value;
    this.concert.singerId = this.concertForm.get('singer').value;

    this.concertService.add(this.concert).subscribe();
  }
}
