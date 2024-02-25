using Models.DTOs.Internal;

namespace Services.Internal
{
    public interface IStatusService
    {
        IQueryable<NomenclatureDTO<int>> GetAll();
        NomenclatureDTO<int> Get(int id);
        void AddOrEdit(NomenclatureDTO<int> dto);
        void Delete(int id);
    }
}