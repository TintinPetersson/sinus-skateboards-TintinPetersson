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
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public virtual CustomerModel Customer { get; set; }
        public virtual List<OrderProductModel> Products { get; set; } 
    }
}
