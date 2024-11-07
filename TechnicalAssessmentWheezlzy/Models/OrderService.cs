using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TechnicalAssessmentWheezlzy.Models
{
    public class OrderService
    {

        private readonly CDBContext dbContext;

        public OrderService(CDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<OrderDTO>> GetOrders(DateTime dateFrom, DateTime dateTo, List<int> customerIds, List<int> statusIds, bool? isActive)
        {
            var query = dbContext.Orders
                .Where(o => o.OrderDate >= dateFrom && o.OrderDate <= dateTo);

            if (customerIds != null && customerIds.Any())
            {
                query = query.Where(o => customerIds.Contains(o.CustomerId));
            }

            if (statusIds != null && statusIds.Any())
            {
                query = query.Where(o => statusIds.Contains(o.StatusId));
            }

            if (isActive.HasValue)
            {
                query = query.Where(o => o.IsActive == isActive);
            }

            var result = await query
                .Select(o => new OrderDTO
                {
                    OrderId = o.OrderId,
                    CustomerId = o.CustomerId,
                    StatusId = o.StatusId,
                    IsActive = o.IsActive
                })
                .ToListAsync();

            return result;
        }
    }
}
