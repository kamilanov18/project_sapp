

export class ProductItemDTO { 
    constructor(obj: Partial<ProductItemDTO>) {
        Object.assign(this,obj);
    }
    public id: number;
    public name: string;
    public count: number;
}
