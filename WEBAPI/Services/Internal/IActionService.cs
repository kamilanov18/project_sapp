using Models.DTOs.Internal.Actions;

namespace Services.Internal
{
    public interface IActionService
    {
        IQueryable<ActionDTO> GetAll();
        ActionDTO Get(int actionId);
        void AddOrEdit(ActionDTO dto);
        void Delete(int id);
    }
}
