namespace Models.DTOs.Internal.Actions
{
    public class ActionReportDTO
    {
        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public decimal Paycheck {get; set; }
        public List<ActionRecordDTO> Actions { get; set;}
    }
}
