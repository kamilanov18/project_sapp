

export class GetCountriesResponseDTO { 
    constructor(obj:Partial<GetCountriesResponseDTO>) {
        Object.assign(this,obj);
    }
    
    public countries: CountryDTO[];
}
