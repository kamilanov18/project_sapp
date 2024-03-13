

export class EditOrderDetailsDTO { 
    constructor(obj: Partial<EditOrderDetailsDTO>) {
        Object.assign(this,obj);
    }
    public id: number;
    public address: AddressDTO;
}
