using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class UsersTbl
{
    public string UserId { get; set; } = null!;

    public string UserFname { get; set; } = null!;

    public string UserLname { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public string? UserPic { get; set; }

    public string UserGender { get; set; } = null!;

    public bool UserIsDelete { get; set; }

    public virtual ICollection<EventToProviderTbl> EventToProviderTbls { get; } = new List<EventToProviderTbl>();

    public virtual ICollection<OpinionToProviderTbl> OpinionToProviderTbls { get; } = new List<OpinionToProviderTbl>();

    public virtual ICollection<ProvidersTbl> ProvidersTbls { get; } = new List<ProvidersTbl>();
}
