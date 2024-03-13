using Models.DTOs.Internal.Orders;

namespace Services.Internal
{
    public interface IOrderService
    {
        IQueryable<OrderDTO> GetAll();
        OrderDetailsDTO GetById(int id);
        void Edit(EditOrderDetailsDTO dto);

    }
}
