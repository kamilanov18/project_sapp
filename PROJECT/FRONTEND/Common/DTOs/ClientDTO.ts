

export class ClientDTO { 
    constructor(obj: Partial<ClientDTO>) {
        Object.assign(this,obj);
    }

    
    public name: string;
    public phones: string[];
}
