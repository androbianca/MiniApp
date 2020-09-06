export class Singer {
    id: string;
    name: string;
    musicType: string

    constructor(init?: Partial<Singer>) {
        Object.assign(this, init);
    }
}