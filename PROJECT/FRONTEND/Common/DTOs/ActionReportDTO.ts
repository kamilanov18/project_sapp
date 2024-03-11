

export class ActionReportDTO { 
    constructor(obj:Partial<ActionReportDTO>) {
        Object.assign(this,obj);
    }
    
    public userId: number;
    public userFirstName: string;
    public userLastName: string;
    public paycheck: number;
    public actions: ActionRecordDTO[];
}
