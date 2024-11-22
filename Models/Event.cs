using System;
using System.Collections.Generic;

namespace EventureApp.Models;

public partial class Event
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime StartDateTime { get; set; }

    public DateTime EndDateTime { get; set; }

    public double Price { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<Attendee> Attendees { get; set; } = new List<Attendee>();

    public virtual User User { get; set; } = null!;
}
