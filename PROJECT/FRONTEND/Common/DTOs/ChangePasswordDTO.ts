

export class ChangePasswordDTO { 
    constructor(obj: Partial<ChangePasswordDTO>) {
        Object.assign(this,obj);
    }

    
    public id: number;
    public passwordHash: string;
}
