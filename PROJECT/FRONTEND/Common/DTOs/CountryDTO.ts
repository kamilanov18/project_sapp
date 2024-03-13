

export class CountryDTO { 
    constructor(obj: Partial<CountryDTO>) {
        Object.assign(this,obj);
    }

    
    public id: number | null;
    public code3: string | null;
    public code2: string | null;
    public name: string | null;
    public nameEn: string | null;
    public isEU: boolean | null;
}
