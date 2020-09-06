export class ConcertView {
    concertName:string;
    price:number;
    singerName: string;
    locationName: string;

    constructor(init?: Partial<ConcertView>) {
        Object.assign(this, init);
    }
}