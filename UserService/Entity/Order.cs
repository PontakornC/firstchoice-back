using System;
using System.Collections.Generic;

namespace UserService.Entity;

public partial class Order
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public decimal TotalPrice { get; set; }

    public string Status { get; set; } = null!;

    public Guid? ShippingAddressId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual UserAddress? ShippingAddress { get; set; }

    public virtual User? User { get; set; }
}
