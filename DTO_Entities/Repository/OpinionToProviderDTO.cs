using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Entities.Repository
{
    public class OpinionToProviderDTO
    {
        public int Opcode { get; set; }

        public DateTime? Opdate { get; set; }

        public string Optext { get; set; } = null!;

        public int ProvCode { get; set; }

        public string UserId { get; set; } = null!;

        public string? Oppic { get; set; }

        public string OpisShow { get; set; } = null!;
        public bool? OpisDelete { get; set; }
    }
}
