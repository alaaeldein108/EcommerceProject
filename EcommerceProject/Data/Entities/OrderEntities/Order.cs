using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.OrderEntities
{
    public enum OrderPaymentStatus
    {
        Pending,
        Recieved,
        Failed
    }
    public class Order:BaseEntity<Guid>
    {
        public string BuyerEmail { get; set; }
        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;
        public ShippingAddress ShippingAddress { get; set; }
        public DeliveryMethod DeliveryMethod { get; set; }
        [ForeignKey("DeliveryMethod")]
        public int DeliveryMethodId { get; set; }
        public OrderPaymentStatus OrderPaymentStatus { get; set; } = OrderPaymentStatus.Pending;
        public IReadOnlyList<OrderItem> OrderItems { get; set; }
        public decimal SubTotal { get; set; }
        public decimal GetTotal()
                   => SubTotal + DeliveryMethod.Price;
        public string? PaymentIntentId { get; set; }
        public string? BasketId { get; set; }
    }
}
