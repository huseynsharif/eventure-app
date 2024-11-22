using System;
using System.Collections.Generic;

namespace EventureApp.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Attendee> Attendees { get; set; } = new List<Attendee>();

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
