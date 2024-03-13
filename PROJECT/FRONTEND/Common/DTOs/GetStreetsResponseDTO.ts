

export class GetStreetsResponseDTO { 
    constructor(obj: Partial<GetStreetsResponseDTO>) {
        Object.assign(this,obj);
    }

    
    public streets: StreetDTO[];
}
