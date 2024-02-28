namespace Services.Helping
{
    public interface IDBSeedingService
    {
        void SeedDatabase();
        public void ConvertForeignTableOrdersToNativeTableOrders();
    }
}