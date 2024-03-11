

export class StreetDTO { 
    constructor(obj:Partial<StreetDTO>) {
        Object.assign(this,obj);
    }
    
    public id: number | null;
    public cityID: number | null;
    public name: string | null;
    public nameEn: string | null;
}
