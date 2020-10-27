import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-concert',
  templateUrl: './concert.component.html',
  styleUrls: ['./concert.component.scss']
})
export class ConcertComponent {
  public addedConcertEvent: Event;

  onConcertAdded(event: Event) {
    this.addedConcertEvent = event;
  }
}
