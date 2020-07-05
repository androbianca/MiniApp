import { Injectable } from '@angular/core';
import { Location } from './location.model';
import { BaseService } from 'src/app/shared/services/base.service';


@Injectable({
    providedIn: 'root'
})
export class LocationService {

    constructor(public baseService: BaseService) {
    }

    public getAll() {
        return this.baseService.get<Location[]>('location');
    }

    public add(location: Location) {
        debugger
        return this.baseService.post<Location>('location', location);
    }
}