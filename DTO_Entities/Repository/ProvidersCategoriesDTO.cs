using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Entities.Repository
{
    public class ProvidersCategoriesDTO
    {
        public short Pccode { get; set; }

        public string? Pcname { get; set; }
        public bool? PcisDelete { get; set; }
    }
}
