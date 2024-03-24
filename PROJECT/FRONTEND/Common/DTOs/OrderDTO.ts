

export class OrderDTO { 
    constructor(obj: Partial<OrderDTO>) {
        Object.assign(this,obj);
    }

    
    public id: number;
    public statusId: number;
    public clientFirstName: string;
    public clientLastName: string;
    public isPossibleDuplicate: boolean;
    public clientAddress: string;
    public products: ProductItemDTO[];
}
