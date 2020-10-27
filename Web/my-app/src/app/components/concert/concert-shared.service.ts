import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class ConcertSharedService {

    private newConcertAdded = new BehaviorSubject(false);
    newConcertAddedObs = this.newConcertAdded.asObservable();

    constructor() { }

    concertAdded(value: boolean) {
        this.newConcertAdded.next(value)
    }

}