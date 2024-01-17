using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Entities.Repository
{
    public class ParametersForCategoryDTO
    {
        public short ParamCcode { get; set; }

        public short Pccode { get; set; }

        public string? ParamCname { get; set; }

        public string? ParamCtype { get; set; }
        public bool? ParamCisDelete { get; set; }

    }
}
