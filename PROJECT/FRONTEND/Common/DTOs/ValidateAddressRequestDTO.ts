

export class ValidateAddressRequestDTO { 
    constructor(obj: Partial<ValidateAddressRequestDTO>) {
        Object.assign(this,obj);
    }

    
    public address: AddressDTO;
}
