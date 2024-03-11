

export class LoginDTO { 
    constructor(obj:Partial<LoginDTO>) {
        Object.assign(this,obj);
    }
    
    public email: string;
    public password: string;
}
