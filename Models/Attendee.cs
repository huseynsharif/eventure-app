using System;
using System.Collections.Generic;

namespace EventureApp.Models;

public partial class Attendee
{
    public int Id { get; set; }

    public int EventId { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual Event Event { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
