export class Coordinates {
    latitude: number;
    longitude: number;

    constructor(init?: Partial<Coordinates>) {
        Object.assign(this, init);
    }
}