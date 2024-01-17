using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EventToProviderTbl
{
    public int Epcode { get; set; }

    public string? Epname { get; set; }

    public DateTime Epdate { get; set; }

    public int ProvCode { get; set; }

    public string? EpwholeDay { get; set; }

    public string UserId { get; set; } = null!;

    public string Epnotes { get; set; } = null!;

    public string Epstatus { get; set; } = null!;

    public bool EpisDelete { get; set; }

    public virtual ProvidersTbl ProvCodeNavigation { get; set; } = null!;

    public virtual UsersTbl User { get; set; } = null!;
}
