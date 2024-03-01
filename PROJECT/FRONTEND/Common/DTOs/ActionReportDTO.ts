

module Models { 
    export class ActionReportDTO { 
        public userId: number;
        public userFirstName: string;
        public userLastName: string;
        public paycheck: number;
        public actions: ActionRecordDTO[];
    }
}