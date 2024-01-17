using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Entities.Repository
{
    public class ProvidersDTO
    {
        public int ProvCode { get; set; }

        public string UserId { get; set; } = null!;

        public string? ProvLogo { get; set; }

        public string? ProvTitle { get; set; }

        public string? ProvAdvertisementText { get; set; }

        public string? ProvPic1 { get; set; }

        public string? ProvPic2 { get; set; }

        public string? ProvPic3 { get; set; }

        public string? ProvPic4 { get; set; }

        public string? ProvPic5 { get; set; }

        public string? ProvPic6 { get; set; }

        public string? ProvPic7 { get; set; }

        public string? ProvPic8 { get; set; }

        public string? ProvEmail { get; set; }

        public string? ProvPhone { get; set; }

        public string? ProvCity { get; set; }

        public string? ProvAddress { get; set; }

        public string? ProvClip { get; set; }

        public string ProvStatus { get; set; } = null!;

        public bool? ProvIsDelete { get; set; }

        public short Pccode { get; set; }
        public string? OtherCategory { get; set; }
    }
}
