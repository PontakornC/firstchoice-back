using System;
using System.Collections.Generic;

namespace UserService.Entity;

public partial class Inventory
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public int StockQuantity { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Product? Product { get; set; }
}
