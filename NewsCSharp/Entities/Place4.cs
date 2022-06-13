using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCSharp.Entities
{
    public record Place4 : Place3
    {
        public string Founder { get; init; }

        public Place4(string name, string founder) => (Name, Founder) = (name, founder);
    }
}
