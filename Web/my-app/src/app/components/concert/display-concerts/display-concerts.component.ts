import { Component, OnInit } from '@angular/core';
import { Concert } from '../concert.model';
import { ConcertService } from '../concert.service';

@Component({
  selector: 'app-display-concerts',
  templateUrl: './display-concerts.component.html',
  styleUrls: ['./display-concerts.component.scss']
})
export class DisplayConcertsComponent implements OnInit {
  concerts: Concert[];
  specificConcert: Concert;
  id: string;
  filterColumns: string[] = ['filterPosition', 'filterName', 'filterWeight', 'filterSymbol'];

  tableModel: string;
  filterModel: string;

  displayedColumns: string[] = ['name', 'price'];
  fixedContentCols: string[] = this.displayedColumns.slice();
  selected(event: any) {}
  pages(event: any) {}
  constructor(public concertService: ConcertService) { }

  ngOnInit(): void {
    this.getConcerts();
  }

  getConcerts(): void {
    this.concertService.getAll().subscribe(concerts => {
      this.concerts = concerts;
    })
  }
}
