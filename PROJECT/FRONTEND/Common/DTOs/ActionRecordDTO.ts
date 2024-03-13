

export class ActionRecordDTO { 
    constructor(obj: Partial<ActionRecordDTO>) {
        Object.assign(this,obj);
    }

    
    public id: number;
    public orderId: number;
    public actionName: string;
    public expense: number;
}
