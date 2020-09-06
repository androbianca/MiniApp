import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BaseService } from 'src/app/shared/services/base.service';
import { Concert } from './concert.model';
import { ConcertView } from './display-concerts/concert-view.model';

@Injectable({
    providedIn: 'root'
})
export class ConcertService {
    constructor(public baseService: BaseService) { }

    public getAllConcerts(): Observable<Concert[]> {
        return this.baseService.get<Concert[]>('concert');
    }

    public getAllConcertViews(): Observable<ConcertView[]> {
        return this.baseService.get<ConcertView[]>('concertView');
    }

    public add(concert: Concert): Observable<Concert> {
        return this.baseService.post<Concert>('concert', concert);
    }

    public getById(id: string): Observable<Concert> {
        return this.baseService.get<Concert>(`concert/${id}`);
    }
}