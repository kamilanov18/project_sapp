using DataAccess.Data;
using Models.DTOs.Internal.Actions;

namespace Services.Internal
{
    public class ActionService : IActionService
    {
        BizlabbgIcanContext _ctx;
        public ActionService(BizlabbgIcanContext ctx)
        {
            _ctx = ctx;
        }

        public void AddOrEdit(ActionDTO dto)
        {
            IcaksSappAction action;
            if (dto.Id == 0)
            {
                action = new();
                _ctx.IcaksSappActions.Add(action);
            }
            else
            {
                action = _ctx.IcaksSappActions.Where(x => x.Id == dto.Id).First();
            }

            action.Name = dto.Name;
            action.Expense = dto.Expense;

            _ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            _ctx.Remove(_ctx.IcaksSappActions.Where(x => x.Id == id).First());
            _ctx.SaveChanges();
        }

        public ActionDTO Get(int id)
        {
            return (from actions in _ctx.IcaksSappActions
                    where actions.Id == id
                    select new ActionDTO() { Id = id, Name = actions.Name, Expense = actions.Expense }
                    ).First();
        }

        public IQueryable<ActionDTO> GetAll()
        {
            return (from actions in _ctx.IcaksSappActions
                    select new ActionDTO() { Id = actions.Id, Name = actions.Name, Expense= actions.Expense }
                    );
        }
    }
}
