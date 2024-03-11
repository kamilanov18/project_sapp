

export class ValidateAddressResponseDTO { 
    constructor(obj:Partial<ValidateAddressResponseDTO>) {
        Object.assign(this,obj);
    }
    
    public address: AddressDTO;
    public validationStatus: string | null;
}
