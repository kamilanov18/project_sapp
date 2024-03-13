

export class EditUserDTO { 
    constructor(obj: Partial<EditUserDTO>) {
        Object.assign(this,obj);
    }

    
    public id: number;
    public firstName: string;
    public lastName: string;
    public email: string;
    public wage: number | null;
    public phone: string;
    public roleIds: number[];
}
