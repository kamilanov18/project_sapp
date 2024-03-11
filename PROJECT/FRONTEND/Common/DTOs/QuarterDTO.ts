

export class QuarterDTO { 
    constructor(obj:Partial<QuarterDTO>) {
        Object.assign(this,obj);
    }
    
    public id: number | null;
    public cityId: number | null;
    public name: string | null;
    public nameEn: string | null;
}
