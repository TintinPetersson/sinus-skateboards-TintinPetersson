using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinusSkateboards.DTO.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public virtual CustomerModel Customer { get; set; }
        public virtual List<ProductModel> Products { get; set; }
    }
}
