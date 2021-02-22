﻿using SalesStatistics.Constants;
using SalesStatistics.DAL.Models;
using System.Collections.Generic;

namespace SalesStatistics.Models
{
    public class OrdersViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public SortParams SortBy { get; set; }
        public SortOrder SortOrder { get; set; }
        public int PageSize { get; set; }
    }
}
