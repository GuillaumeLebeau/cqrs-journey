using System;
using System.Collections.Generic;

namespace Conference.Web.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid ConferenceId { get; set; }
        public string ConferenceCode { get; set; }
        public string ConferenceName { get; set; }
        public IEnumerable<OrderItem> Items { get; set; }
        public double Total { get; set; }
    }
    
    public class OrderItem
    {
        public Guid SeatTypeId { get; set; }
        public string SeatTypeDescription { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total => this.Price * this.Quantity;
    }
}
