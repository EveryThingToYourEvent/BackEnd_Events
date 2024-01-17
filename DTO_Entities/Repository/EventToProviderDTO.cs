using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Entities.Repository
{
    public class EventToProviderDTO
    {
        public int Epcode { get; set; }
        public string Epname { get; set; }

        public DateTime? Epdate { get; set; }

        public int? ProvCode { get; set; }

        public string? EpwholeDay { get; set; }

        public string? UserId { get; set; }

        public string? Epnotes { get; set; }

        public string? Epstatus { get; set; }
        public bool? EpisDelete { get; set; }
        public string? backgroundColor { get; set; }
        public string? title { get;set; }
        public DateTime? start { get; set; }  
        public bool? allDay{ get; set; }
        public DateTime? EPstartTime { get; set; }
        public DateTime? EPendTime { get; set; }
        public bool? EpIsAllDate { get; set; }
    }
}
