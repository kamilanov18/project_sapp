﻿using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace Services.Helping
{
    public class DBSeedingService : IDBSeedingService
    {
        BizlabbgIcanContext _ctx;
        public DBSeedingService(BizlabbgIcanContext ctx)
        {
            _ctx = ctx;
        }

        public void ConvertForeignTableOrdersToNativeTableOrders()
        {
            if (_ctx.IcaksSappOrders.Count() > 0)
                return;
            List<IcaksSappOrder> orders = new();
            foreach (var order in _ctx.IcaksWcOrders.AsNoTracking())
            {
                var newOrder = new IcaksSappOrder()
                {
                    ForeignOrderId=order.Id,
                    ForeignOrderTableId=1,
                };
                switch(order.Status)
                {
                    case "wc-processing": newOrder.StatusId = 1; break;
                    case "wc-failed": newOrder.StatusId = 6; break;
                    case "wc-cancelled": newOrder.StatusId = 5; break;
                    case "wc-completed": newOrder.StatusId = 4; break;
                    case "trash": newOrder.StatusId = 6; break;
                    case "auto-draft": newOrder.StatusId = 1; break;
                }

                orders.Add(newOrder);
            }

            orders.ForEach(x => x.IsPossibleDuplicate = IsOrderDuplicate(x));

            _ctx.IcaksSappOrders.AddRange(orders);
            _ctx.SaveChanges();
        }

        private bool IsOrderDuplicate(IcaksSappOrder order)
        {
            var orderToCmp = (
                           from a in _ctx.IcaksWcOrderAddresses
                           join lp in _ctx.IcaksWcOrderProductLookups on a.OrderId equals lp.OrderId
                           join mp in _ctx.IcaksWcProductMetaLookups on lp.ProductId equals (ulong)mp.ProductId
                           where a.OrderId == order.ForeignOrderId && a.AddressType == "shipping"
                           select new { a.Address1,a.Address2,a.Country,a.FirstName,a.LastName,a.Email,a.City,a.State,a.Postcode,a.Phone,mp.Sku,lp.ProductQty }
                           ).AsNoTracking().FirstOrDefault();
            if (orderToCmp == default)
            {
                order.StatusId = 6;
                return false;
            }
            var duplicateRows = (
                           from a in _ctx.IcaksWcOrderAddresses
                           join lp in _ctx.IcaksWcOrderProductLookups on a.OrderId equals lp.OrderId
                           join mp in _ctx.IcaksWcProductMetaLookups on lp.ProductId equals (ulong)mp.ProductId
                           where a.Address1 == orderToCmp.Address1 &&
                           a.Address2 == orderToCmp.Address2 &&
                           a.Country == orderToCmp.Country &&
                           a.FirstName == orderToCmp.FirstName &&
                           a.LastName == orderToCmp.LastName &&
                           a.Email == orderToCmp.Email &&
                           a.City == orderToCmp.City &&
                           a.State == orderToCmp.State &&
                           a.Postcode == orderToCmp.Postcode &&
                           a.Phone == orderToCmp.Phone &&
                           mp.Sku == orderToCmp.Sku &&
                           lp.ProductQty == orderToCmp.ProductQty && 
                           a.AddressType == "shipping"
                           select new {a.Address1}).AsNoTracking().ToList();
            return duplicateRows.Count>1;
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
                Phone = "0888208415",
            };

            List<IcaksSappRole> roles = new()
            {
                new() {Name="admin"},
                new() {Name="operator"},
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
                new() {Name="Confirm Order",Expense=0.2m},
                new() {Name="Package",Expense=0.3m},
            };

            List<IcaksSappStatus> statuses = new()
            {
                new() {Name="New Order"},
                new() {Name="Waybill Generated"},
                new() {Name="Sent"},
                new() {Name="Delivered"},
                new() {Name="Cancelled"},
                new() {Name="Failed"},
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