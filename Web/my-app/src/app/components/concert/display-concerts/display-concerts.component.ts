import { Component, OnInit } from '@angular/core';
import { ConcertService } from '../concert.service';
import { SingerService } from 'src/app/shared/services/singer.service';
import { LocationService } from 'src/app/shared/services/location.service';
import { ConcertView } from './concert-view.model';

@Component({
  selector: 'app-display-concerts',
  templateUrl: './display-concerts.component.html',
  styleUrls: ['./display-concerts.component.scss']
})
export class DisplayConcertsComponent implements OnInit {
  concerts: ConcertView[];
  displayedColumns: string[] = ['concertName', 'price', 'locationName', 'singerName'];
  fixedContentCols: string[] = this.displayedColumns.slice();

  constructor(public concertService: ConcertService,
    public singerService: SingerService,
    public locationService: LocationService) { }

  ngOnInit(): void {
    this.getConcerts();
  }

  getConcerts(): void {
    this.concertService.getAllConcertViews().subscribe(concerts => {
      this.concerts = concerts;
    })
  }
}
