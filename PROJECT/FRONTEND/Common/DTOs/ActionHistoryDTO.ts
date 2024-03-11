

export class ActionHistoryDTO { 
    constructor(obj:Partial<ActionHistoryDTO>) {
        Object.assign(this,obj);
    }
    
    public id: number;
    public actionId: number;
    public actionName: number;
    public actionExpense: number;
    public userId: number;
    public orderId: number;
    public date: Date;
}
