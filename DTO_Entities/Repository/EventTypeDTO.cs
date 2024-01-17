using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Entities.Repository
{
    public class EventTypeDTO
    {
        public short EventTypeCode { get; set; }

        public string? EventTypeName { get; set; }

        public string? EventTypeLogo { get; set; }
        public bool? EventTypeIsDelete { get; set; }
    }
}
