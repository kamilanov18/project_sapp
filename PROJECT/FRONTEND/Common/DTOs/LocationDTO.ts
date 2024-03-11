

export class LocationDTO { 
    constructor(obj:Partial<LocationDTO>) {
        Object.assign(this,obj);
    }
    
    public latitude: number | null;
    public longtitude: number | null;
    public confidence: number | null;
}
