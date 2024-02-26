namespace Models.DTOs.Internal.Actions
{
    public class ActionRecordDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ActionName { get; set; }
        public decimal Expense { get; set; }
    }
}
