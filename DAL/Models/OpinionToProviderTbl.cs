using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class OpinionToProviderTbl
{
    public int Opcode { get; set; }

    public DateTime Opdate { get; set; }

    public string Optext { get; set; } = null!;

    public int ProvCode { get; set; }

    public string UserId { get; set; } = null!;

    public string? Oppic { get; set; }

    public string OpisShow { get; set; } = null!;

    public bool OpisDelete { get; set; }

    public virtual ProvidersTbl ProvCodeNavigation { get; set; } = null!;

    public virtual UsersTbl User { get; set; } = null!;
}
