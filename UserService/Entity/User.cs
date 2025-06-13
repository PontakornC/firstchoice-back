using System;
using System.Collections.Generic;

namespace UserService.Entity;

public partial class User
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? Username { get; set; }

    public string? Passwordhash { get; set; }

    public DateTime? Createdate { get; set; }
}
