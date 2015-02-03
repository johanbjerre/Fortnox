using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortnox.ValueObjects
{
    public class ResponseBase
    {
        public string ErrorMessage { get; set; }
        public bool Success { get; set; }
    }
}
