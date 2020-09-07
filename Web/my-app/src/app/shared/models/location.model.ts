export class Location {
    id: string;
    country: string;
    county: string;
    name: string;
    street: string

    constructor(init?: Partial<Location>) {
        Object.assign(this, init);
    }
}