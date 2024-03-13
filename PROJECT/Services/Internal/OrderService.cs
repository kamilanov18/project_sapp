﻿using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models.DTOs.Internal.Orders;
using Models.DTOs.Internal.Products;

namespace Services.Internal
{
    public class OrderService : IOrderService
    {
        BizlabbgIcanContext _ctx;
        public OrderService(BizlabbgIcanContext ctx)
        {
            _ctx = ctx;
        }
        public void Edit(EditOrderDetailsDTO dto)
        {
            try
            {
                IcaksSappOrder order = _ctx.IcaksSappOrders.Where(x => x.Id == dto.Id).First();

            }
            catch (Exception)
            {
                throw new InvalidDataException("errors.invalid-id");
            }
            
        }

        public IQueryable<OrderDTO> GetAll()
        {
            return (from o in _ctx.IcaksSappOrders
                    join wco in _ctx.IcaksWcOrders on o.ForeignOrderId equals wco.Id
                    join wca in _ctx.IcaksWcOrderAddresses on wco.Id equals wca.OrderId
                    where wca.AddressType == "shipping"
                    select new OrderDTO
                    {
                        Id = o.Id,
                        IsPossibleDuplicate = o.IsPossibleDuplicate,
                        StatusId = o.StatusId,
                        ClientAddress = $"{wca.Country} {wca.City} {wca.State} {wca.Postcode} {wca.Address1} {wca.Address2}",
                        ClientNames = $"{wca.FirstName} {wca.LastName}",
                        Products = (from wcp in _ctx.IcaksWcOrderProductLookups
                                    join lp in _ctx.IcaksWcProductMetaLookups on wcp.ProductId equals (ulong)lp.ProductId
                                    where wcp.OrderId == o.ForeignOrderId
                                    select new ProductItemDTO
                                    {
                                        Count = wcp.ProductQty,
                                        Name = lp.Sku,
                                        Id = (int)wcp.OrderItemId
                                    }).AsNoTracking().ToList()
                    }).AsNoTracking();
        }

        public OrderDetailsDTO GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}