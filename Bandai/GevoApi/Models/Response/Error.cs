using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandai.GevoApi.Models.Response
{
    public record Error
    {
        public int errCode { get; set; } = 0;
        public int subCode { get; set; } = 0;
        public string param1 { get; set; } = "";
    }
}
