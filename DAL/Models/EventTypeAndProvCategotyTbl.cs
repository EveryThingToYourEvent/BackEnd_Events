using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EventTypeAndProvCategotyTbl
{
    public int EventTypeProvcode { get; set; }

    public short EventTypeCode { get; set; }

    public short Pccode { get; set; }

    public virtual EventTypeTbl EventTypeCodeNavigation { get; set; } = null!;

    public virtual ProvidersCategoriesTbl PccodeNavigation { get; set; } = null!;
}
