import { Injectable } from '@angular/core';
import { Singer } from './singer.model';
import { BaseService } from 'src/app/shared/services/base.service';

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
}