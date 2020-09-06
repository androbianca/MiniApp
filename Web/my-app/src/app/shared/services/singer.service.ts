import { Injectable } from '@angular/core';
import { Singer } from '../models/singer.model';
import { BaseService } from './base.service';

@Injectable({
    providedIn: 'root'
})
export class SingerService {

    constructor(public baseService: BaseService) {}

    public getAll() {
        return this.baseService.get<Singer[]>('singer');
    }

    public add(singer: Singer) {
        return this.baseService.post<Singer>('singer', singer);
    }

    public getById(id: string) {
        return this.baseService.get<Singer>(`singer/${id}`);
    }
}