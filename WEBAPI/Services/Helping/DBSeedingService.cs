using DataAccess.Data;

namespace Services.Helping
{
    public class DBSeedingService : IDBSeedingService
    {
        BizlabbgIcanContext _ctx;
        public DBSeedingService(BizlabbgIcanContext ctx)
        {
            _ctx = ctx;
        }
        public void SeedDatabase()
        {
            if (_ctx.IcaksSappUsers.Count() > 0)
                return;

            IcaksSappUser admin = new()
            {
                Email = "a@a",
                PasswordHash = "123",
                FirstName = "Admin",
                LastName = "Admin",
                Phone = "0887769203",
            };

            List<IcaksSappRole> roles = new()
            {
                new() {Name="admin"},
                new() {Name="caller"},
                new() {Name="packager"},
            };

            List<IcaksSappUsersRole> userRoles = new()
            {
                new() {RoleId=1,UserId=1}
            };

            IcaksSappForeignOrderTable foreignOrderTable = new() { Name = "wc-orders" };

            List<IcaksSappAction> actions = new()
            {
                new() {Name="Make Call",Expense=0.2m},
                new() {Name="Package",Expense=0.3m},
            };

            List<IcaksSappStatus> statuses = new()
            {
                new() {Name="New Order"},
                new() {Name="Sent"},
                new() {Name="Delivered"},
            };

            _ctx.IcaksSappUsers.Add(admin);
            _ctx.IcaksSappRoles.AddRange(roles);
            _ctx.IcaksSappUsersRoles.AddRange(userRoles);
            _ctx.IcaksSappForeignOrderTables.AddRange(foreignOrderTable);
            _ctx.IcaksSappActions.AddRange(actions);
            _ctx.IcaksSappStatuses.AddRange(statuses);

            _ctx.SaveChanges();
        }
    }
}
