import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Location } from '../models/location.model';
import { BaseService } from './base.service';

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

    public getById(id: string) {
        return this.baseService.get<Location>(`location/${id}`);
    }
}