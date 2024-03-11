

export class OrderDTO { 
    constructor(obj:Partial<OrderDTO>) {
        Object.assign(this,obj);
    }
    
    public id: number;
    public statusId: number;
    public clientNames: string;
    public isPossibleDuplicate: boolean;
    public clientAddress: string;
    public products: string;
    public productCounts: string;
}
