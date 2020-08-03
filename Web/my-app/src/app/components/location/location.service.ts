import { Injectable } from '@angular/core';
import { Location } from './location.model';
import { BaseService } from 'src/app/shared/services/base.service';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class LocationService {

    constructor(public baseService: BaseService) { }

    public getAll(): Observable<Location[]> {
        return this.baseService.get<Location[]>('location');
    }

    public add(location: Location): Observable<Location> {
        return this.baseService.post<Location>('location', location);
    }
}