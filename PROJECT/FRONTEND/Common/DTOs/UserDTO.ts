

export class UserDTO { 
    constructor(obj: Partial<UserDTO>) {
        Object.assign(this,obj);
    }

    
    public id: number;
    public firstName: string;
    public lastName: string;
    public email: string;
    public wage: number | null;
    public phone: string;
}
