export class Location {
    id: string;
    country: string;
    county: string;
    name: string;
    street: string
    latitude:string;
    longitude:string;

    constructor(init?: Partial<Location>) {
        Object.assign(this, init);
    }
}