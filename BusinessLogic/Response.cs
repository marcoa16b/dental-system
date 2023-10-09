using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * * @param <T> The type of the value being returned
 * */

namespace BusinessLogic
{
    public class Response
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
    }
}
