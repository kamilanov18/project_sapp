

export class GetCitiesResponseDTO { 
    constructor(obj: Partial<GetCitiesResponseDTO>) {
        Object.assign(this,obj);
    }

    
    public cities: CityDTO[];
}
