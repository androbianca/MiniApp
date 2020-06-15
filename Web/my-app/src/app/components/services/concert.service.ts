import { Injectable } from '@angular/core';
import { BaseService } from './base.service';
import { Concert } from '../models/concert';


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