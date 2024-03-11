

export class UpdateUserRolesDTO { 
    constructor(obj:Partial<UpdateUserRolesDTO>) {
        Object.assign(this,obj);
    }
    
    public userRoles: UserRolesDTO[];
}
