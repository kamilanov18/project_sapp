

export class ShippingAddressDTO { 
    constructor(obj: Partial<ShippingAddressDTO>) {
        Object.assign(this,obj);
    }

    
    public address: AddressDTO;
}
