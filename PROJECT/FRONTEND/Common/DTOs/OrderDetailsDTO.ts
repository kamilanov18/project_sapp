

export class OrderDetailsDTO { 
    constructor(obj: Partial<OrderDetailsDTO>) {
        Object.assign(this,obj);
    }

    
    public id: number;
    public clientFirstName: string;
    public clientLastName: string;
    public providedAddress: string;
    public address: IAddressDTO;
}
