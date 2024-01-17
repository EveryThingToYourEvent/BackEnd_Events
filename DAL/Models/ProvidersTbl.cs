using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ProvidersTbl
{
    public int ProvCode { get; set; }

    public string UserId { get; set; } = null!;

    public string? ProvLogo { get; set; }

    public string ProvTitle { get; set; } = null!;

    public string ProvAdvertisementText { get; set; } = null!;

    public string ProvPic1 { get; set; } = null!;

    public string ProvPic2 { get; set; } = null!;

    public string ProvPic3 { get; set; } = null!;

    public string ProvPic4 { get; set; } = null!;

    public string? ProvPic5 { get; set; }

    public string? ProvPic6 { get; set; }

    public string? ProvPic7 { get; set; }

    public string? ProvPic8 { get; set; }

    public string? ProvEmail { get; set; }

    public string ProvPhone { get; set; } = null!;

    public string ProvCity { get; set; } = null!;

    public string ProvAddress { get; set; } = null!;

    public string? ProvClip { get; set; }

    public string ProvStatus { get; set; } = null!;

    public bool ProvIsDelete { get; set; }

    public short Pccode { get; set; }

    public string? OtherCategory { get; set; }

    public virtual ICollection<EventToProviderTbl> EventToProviderTbls { get; } = new List<EventToProviderTbl>();

    public virtual ICollection<OpinionToProviderTbl> OpinionToProviderTbls { get; } = new List<OpinionToProviderTbl>();

    public virtual ProvidersCategoriesTbl PccodeNavigation { get; set; } = null!;

    public virtual UsersTbl User { get; set; } = null!;
}
