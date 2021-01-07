using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Domain.Security
{
    public class TokenConfig
    {
        public string Publico { get; set; }
        public string Emissor { get; set; }
        public double Segundos { get; set; }
    }
}
