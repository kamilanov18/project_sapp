namespace Models.DTOs.Internal.Actions
{
    public class ActionHistoryDTO
    {
        public int Id { get; set; }
        public int ActionId { get; set; }
        public int ActionName { get; set; }
        public decimal ActionExpense { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
    }
}
