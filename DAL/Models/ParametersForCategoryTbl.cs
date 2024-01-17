using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ParametersForCategoryTbl
{
    public short ParamCcode { get; set; }

    public short Pccode { get; set; }

    public string ParamCname { get; set; } = null!;

    public string? ParamCtype { get; set; }

    public bool ParamCisDelete { get; set; }

    public virtual ProvidersCategoriesTbl PccodeNavigation { get; set; } = null!;
}
