using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.OrderEntities
{
    public class ProductItemOrdered
    {
        public int ProductItemId { get; set; }
        public string ProductName { get; set; }
        public string PictureUrl { get; set; }
    }
}
