using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandai.GevoApi.Models.Response
{
    public record Base
    {
        public Error? error { get; set; }
        public bool IsError => error != null;
    }
}
