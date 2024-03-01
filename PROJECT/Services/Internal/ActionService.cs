using DataAccess.Data;
using Models.DTOs.Internal.Actions;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public ActionDTO Get(string actionName)
        {
            return (from actions in _ctx.IcaksSappActions
                    where actions.Name == actionName
                    select new ActionDTO() { Id = actions.Id, Name = actions.Name, Expense = actions.Expense }
                    ).First();
        }

        public ActionReportDTO GetActionReportForUser(int userId)
        {
            var res = (from actions in _ctx.IcaksSappActions
                       join history in _ctx.IcaksSappActionHistories on actions.Id equals history.ActionId
                       join users in _ctx.IcaksSappUsers on history.UserId equals userId
                       where history.UserId == userId
                       select new
                       {
                           ActionName = actions.Name,
                           Expense = actions.Expense,
                           OrderId = history.OrderId,
                           Id = history.Id,
                           UserFirstName = users.FirstName,
                           UserLastName = users.LastName,
                       }).Distinct().ToList();

            return new ActionReportDTO()
            {
                Actions = res.Select(x => new ActionRecordDTO()
                {
                    ActionName = x.ActionName,
                    Expense = x.Expense,
                    Id = x.Id,
                    OrderId = x.OrderId
                }).ToList(),
                UserId = userId,
                UserFirstName = res.First().UserFirstName,
                UserLastName = res.First().UserLastName,
                Paycheck = res.Select(x => x.Expense).Sum()
            };
        }

        public ActionReportDTO GetActionReportForUserForDate(int userId, DateTime date)
        {
            var res = (from actions in _ctx.IcaksSappActions
                       join history in _ctx.IcaksSappActionHistories on actions.Id equals history.ActionId
                       join users in _ctx.IcaksSappUsers on history.UserId equals userId
                       where history.UserId == userId &&
                       history.Date.Year == date.Year &&
                       history.Date.Month == date.Month
                       select new
                       {
                           ActionName = actions.Name,
                           Expense = actions.Expense,
                           OrderId = history.OrderId,
                           Id = history.Id,
                           UserFirstName = users.FirstName,
                           UserLastName = users.LastName,
                       }).Distinct().ToList();

            return new ActionReportDTO()
            {
                Actions = res.Select(x => new ActionRecordDTO()
                {
                    ActionName = x.ActionName,
                    Expense = x.Expense,
                    Id = x.Id,
                    OrderId = x.OrderId
                }).ToList(),
                UserId = userId,
                UserFirstName = res.First().UserFirstName,
                UserLastName = res.First().UserLastName,
                Paycheck = res.Select(x => x.Expense).Sum()
            };
        }

        public ActionReportDTO GetActionReportForUserForDate(int userId, DateTime start, DateTime endDate)
        {
            var res = (from actions in _ctx.IcaksSappActions
                       join history in _ctx.IcaksSappActionHistories on actions.Id equals history.ActionId
                       join users in _ctx.IcaksSappUsers on history.UserId equals userId
                       where history.UserId == userId &&
                       history.Date >= start && history.Date <= endDate
                       select new
                       {
                           ActionName = actions.Name,
                           Expense = actions.Expense,
                           OrderId = history.OrderId,
                           Id = history.Id,
                           UserFirstName = users.FirstName,
                           UserLastName = users.LastName,
                       }).Distinct().ToList();

            return new ActionReportDTO()
            {
                Actions = res.Select(x => new ActionRecordDTO()
                {
                    ActionName = x.ActionName,
                    Expense = x.Expense,
                    Id = x.Id,
                    OrderId = x.OrderId
                }).ToList(),
                UserId = userId,
                UserFirstName = res.First().UserFirstName,
                UserLastName = res.First().UserLastName,
                Paycheck = res.Select(x => x.Expense).Sum()
            };
        }

        public IQueryable<ActionDTO> GetAll()
        {
            return (from actions in _ctx.IcaksSappActions
                    select new ActionDTO() { Id = actions.Id, Name = actions.Name, Expense= actions.Expense }
                    );
        }

        public IQueryable<ActionHistoryDTO> GetAllHistory()
        {
            throw new NotImplementedException();
        }

        public void RegisterAction(int userId, int actionId, int orderId)
        {
            _ctx.IcaksSappActionHistories.Add(new IcaksSappActionHistory()
            {
                ActionId = actionId,
                Date = DateTime.Now,
                OrderId = orderId,
                UserId = userId
            });

            _ctx.SaveChanges();
        }

        public void RegisterAction(ActionHistoryDTO dto)
        {
            RegisterAction(dto.UserId,dto.ActionId,dto.OrderId);
        }
    }
}
