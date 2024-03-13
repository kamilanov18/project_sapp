

export class NomenclatureDTO<T> { 
    constructor(obj: Partial<NomenclatureDTO<T>>) {
        Object.assign(this,obj);
    }

    
    public id: T;
    public name: string;
}
