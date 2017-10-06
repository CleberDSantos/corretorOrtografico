using System;
using System.Collections.Generic;

namespace CorretorLib
{
    public class CorretorResponse
    {
        public CorretorResponse()
        {
            Sugestoes = new List<string>();
        }

        public bool IsCorreto { get; set; }
        public List<String> Sugestoes { get; set; }
    }
}
