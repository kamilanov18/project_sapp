

export class UserRolesDTO { 
    constructor(obj: Partial<UserRolesDTO>) {
        Object.assign(this,obj);
    }

    
    public userId: number;
    public roleIds: number[];
}
