using DataAccess.Data;
using Microsoft.Extensions.Logging;
using Models.DTOs.Internal;

namespace Services.Internal
{
    public class StatusService: IStatusService
    {
        BizlabbgIcanContext _ctx;
        public StatusService(BizlabbgIcanContext ctx)
        {
            _ctx = ctx;
        }

        public void AddOrEdit(NomenclatureDTO<int> dto)
        {
            IcaksSappStatus status;
            if(dto.Id == 0)
            {
                status = new();
                _ctx.IcaksSappStatuses.Add(status);
            }
            else
            {
                status = _ctx.IcaksSappStatuses.Where(x=>x.Id==dto.Id).First();
            }

            status.Name = dto.Name;

            _ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            _ctx.Remove(_ctx.IcaksSappStatuses.Where(x => x.Id == id).First());
            _ctx.SaveChanges();
        }

        public NomenclatureDTO<int> Get(int id)
        {
            return (from statuses in _ctx.IcaksSappStatuses
                    where statuses.Id == id
                    select new NomenclatureDTO<int>() { Id=id,Name =statuses.Name}
                    ).First();
        }

        public IQueryable<NomenclatureDTO<int>> GetAll()
        {
            return (from statuses in _ctx.IcaksSappStatuses
                    select new NomenclatureDTO<int>() { Id = statuses.Id, Name = statuses.Name }
                    );
        }
    }
}
