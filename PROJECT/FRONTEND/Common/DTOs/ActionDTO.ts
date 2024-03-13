

export class ActionDTO { 
    constructor(obj: Partial<ActionDTO>) {
        Object.assign(this,obj);
    }

    
    public id: number;
    public name: string;
    public expense: number;
}
