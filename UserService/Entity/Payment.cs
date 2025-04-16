using System;
using System.Collections.Generic;

namespace UserService.Entity;

public partial class Payment
{
    public Guid Id { get; set; }

    public Guid? OrderId { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public string Status { get; set; } = null!;

    public decimal Amount { get; set; }

    public DateTime? PaymentDate { get; set; }

    public virtual Order? Order { get; set; }
}
