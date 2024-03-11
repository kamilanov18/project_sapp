

export class EcontShipmentDTO { 
    constructor(obj:Partial<EcontShipmentDTO>) {
        Object.assign(this,obj);
    }
    
    public label: ShippingLabelDTO;
    public mode: string;
}
