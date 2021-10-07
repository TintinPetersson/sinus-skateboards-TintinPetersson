using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinusSkateboards.DTO.Models
{
    public class OrderProductModel
    {
        public int Id { get; set; }
        public int OrderModelId { get; set; }
        public virtual OrderModel OrderModel { get; set; }
        public int ProductModelId { get; set; }
        public virtual ProductModel ProductModel { get; set; }
    }
}
