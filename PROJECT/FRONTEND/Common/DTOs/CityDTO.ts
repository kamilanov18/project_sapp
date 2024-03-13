

export class CityDTO { 
    constructor(obj: Partial<CityDTO>) {
        Object.assign(this,obj);
    }

    
    public country: CountryDTO;
    public name: string | null;
    public postCode: string | null;
    public nameEn: string | null;
    public regionName: string | null;
    public regionNameEn: string | null;
    public phoneCode: string | null;
    public location: LocationDTO;
    public expressCityDeliveries: boolean | null;
    public monday: boolean | null;
    public tuesday: boolean | null;
    public wednesday: boolean | null;
    public thursday: boolean | null;
    public friday: boolean | null;
    public saturday: boolean | null;
    public sunday: boolean | null;
    public serviceDays: number | null;
    public zoneId: number | null;
    public zoneName: string | null;
    public zoneNameEn: string | null;
}
