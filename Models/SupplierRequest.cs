using System;

namespace Models
{
    public class SupplierRequest
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ClientEmail { get; set; }
        public string ProductType { get; set; }
        public int Quantity { get; set; }
        public DateTime RequestDate { get; set; }
        public string Comments { get; set; }
    }
}