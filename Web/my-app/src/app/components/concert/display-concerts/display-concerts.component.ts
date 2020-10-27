import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { SingerService } from 'src/app/shared/services/singer.service';
import { LocationService } from 'src/app/shared/services/location.service';
import { ConcertService } from '../concert.service';
import { ConcertView } from './concert-view.model';
import { ConcertSharedService } from '../concert-shared.service';

@Component({
  selector: 'app-display-concerts',
  templateUrl: './display-concerts.component.html',
  styleUrls: ['./display-concerts.component.scss']
})
export class DisplayConcertsComponent implements OnInit {
  
  @Input() event: Event;

  concerts: ConcertView[];
  displayedColumns: string[] = ['concertName', 'price', 'locationName', 'singerName'];
  fixedContentCols: string[] = this.displayedColumns.slice();

  constructor(
    public concertService: ConcertService,
    public singerService: SingerService,
    public locationService: LocationService,
    private concertSharedService: ConcertSharedService) { }

  ngOnInit(): void {
    this.getConcerts();
    this.concertSharedService.newConcertAddedObs.subscribe(()=> this.getConcerts())
  }

  private getConcerts(): void {
    this.concertService.getAllConcertViews().subscribe(concerts => {
      this.concerts = concerts;
    })
  }
}
