using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EventTypeTbl
{
    public short EventTypeCode { get; set; }

    public string EventTypeName { get; set; } = null!;

    public string? EventTypeLogo { get; set; }

    public bool EventTypeIsDelete { get; set; }

    public virtual ICollection<EventTypeAndProvCategotyTbl> EventTypeAndProvCategotyTbls { get; } = new List<EventTypeAndProvCategotyTbl>();
}
