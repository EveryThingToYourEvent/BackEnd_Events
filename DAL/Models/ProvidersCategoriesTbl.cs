using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ProvidersCategoriesTbl
{
    public short Pccode { get; set; }

    public string Pcname { get; set; } = null!;

    public bool PcisDelete { get; set; }

    public virtual ICollection<EventTypeAndProvCategotyTbl> EventTypeAndProvCategotyTbls { get; } = new List<EventTypeAndProvCategotyTbl>();

    public virtual ICollection<ParametersForCategoryTbl> ParametersForCategoryTbls { get; } = new List<ParametersForCategoryTbl>();

    public virtual ICollection<ProvidersTbl> ProvidersTbls { get; } = new List<ProvidersTbl>();
}
