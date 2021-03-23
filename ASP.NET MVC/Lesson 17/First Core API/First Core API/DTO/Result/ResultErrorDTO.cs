using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_Core_API.DTO.Result
{
    public class ResultErrorDTO : ResultDTO
    {
        public List<string> Error { get; set; }
    }
}
