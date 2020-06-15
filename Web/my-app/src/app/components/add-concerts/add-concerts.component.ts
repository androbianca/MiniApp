import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { ConcertService } from '../services/concert.service';
import { Concert } from '../models/concert';

@Component({
  selector: 'app-add-concerts',
  templateUrl: './add-concerts.component.html',
  styleUrls: ['./add-concerts.component.scss']
})
export class AddConcertsComponent implements OnInit {

  @Output() concertAdded = new EventEmitter<any>();
  concertForm: FormGroup;
  concert= new Concert();
  
  constructor(public concertService:ConcertService) { }

  ngOnInit(): void {
    this.initForm();
  }

  initForm(): void {
    this.concertForm = new FormGroup({
      singer: new FormControl(''),
      price: new FormControl(''),
      location: new FormControl('')
    })
  }

  submit(): void {
    this.concert.singer = this.concertForm.get('singer').value;
    this.concert.location = this.concertForm.get('location').value;
    this.concert.price = +this.concertForm.get('price').value;

    this.concertService.add(this.concert).subscribe(x => this.concertAdded.emit(x));
  }
}
