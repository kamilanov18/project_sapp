

export class ProductDTO { 
    constructor(obj: Partial<ProductDTO>) {
        Object.assign(this,obj);
    }

    
    public id: number;
    public name: string;
    public weight: number | null;
}
