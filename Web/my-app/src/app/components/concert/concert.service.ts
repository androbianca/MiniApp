import { Injectable } from '@angular/core';
import { BaseService } from 'src/app/shared/services/base.service';
import { Concert } from './concert.model';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class ConcertService {
    constructor(public baseService: BaseService) { }

    public getAll(): Observable<Concert[]> {
        return this.baseService.get<Concert[]>('concert');
    }

    public add(concert: Concert): Observable<Concert> {
        return this.baseService.post<Concert>('concert', concert);
    }

    public getById(id: string): Observable<Concert> {
        return this.baseService.get<Concert>(`concert/${id}`);
    }
}