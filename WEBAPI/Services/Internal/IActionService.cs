using Models.DTOs.Internal.Actions;

namespace Services.Internal
{
    public interface IActionService
    {
        IQueryable<ActionDTO> GetAll();
        ActionDTO Get(int actionId);
        ActionDTO Get(string actionName);
        void AddOrEdit(ActionDTO dto);
        void Delete(int id);
        void RegisterAction(int userId, int actionId, int orderId);
        IQueryable<ActionHistoryDTO> GetAllHistory();
        ActionReportDTO GetActionReportForUser(int userId);
        ActionReportDTO GetActionReportForUserForDate(int userId,DateTime date);
        ActionReportDTO GetActionReportForUserForDate(int userId,DateTime start,DateTime endDate);

    }
}
