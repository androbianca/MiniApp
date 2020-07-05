import { Injectable } from '@angular/core';
import { BaseService } from 'src/app/shared/services/base.service';
import { Concert } from './concert.model';


@Injectable({
    providedIn: 'root'
})
export class ConcertService {

    constructor(public baseService: BaseService) {
    }

    public getAll() {
        return this.baseService.get<Concert[]>('concert');
    }

    public add(concert: Concert) {
        return this.baseService.post<Concert>('concert', concert);
    }

    public getById(id:string) {
        return this.baseService.get<Concert>(`concert/${id}`);
    }

}