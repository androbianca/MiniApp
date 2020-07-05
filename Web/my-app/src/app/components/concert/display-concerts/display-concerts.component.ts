// import { Component, OnInit, Input } from '@angular/core';
// import { ConcertService } from '../services/concert.service';
// import { Concert } from '../models/concert';

// @Component({
//   selector: 'app-display-concerts',
//   templateUrl: './display-concerts.component.html',
//   styleUrls: ['./display-concerts.component.scss']
// })
// export class DisplayConcertsComponent implements OnInit {

//   concerts: Concert[];
//   specificConcert: Concert;
//   id: string;

//   constructor(public concertService: ConcertService) { }

//   ngOnInit(): void {
//     this.getConcerts();
//   }

//   getConcerts(): void {
//     this.concertService.getAll().subscribe(concerts => {
//       this.concerts = concerts;
//     })
//   }

//   getById(): void {
//     this.concertService.getById(this.id).subscribe(concert => {
//       this.specificConcert = concert;
//     })
//   }

//   onAddedConcert(concert){
//     this.concerts.push(concert)
//   }
// }
