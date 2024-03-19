namespace Services.Helping
{
    public interface IDBSeedingService
    {
        Task SeedDatabase();
        public void ConvertForeignTableOrdersToNativeTableOrders();
    }
}