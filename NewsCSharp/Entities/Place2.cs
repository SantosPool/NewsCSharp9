using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCSharp.Entities
{
    public record Place2
    {
        public string Name { get; init; }
        public string Founder { get; init; }

        public Place2(string name, string founder) => (Name, Founder) = (name, founder);
        public void Deconstruct(out string name, out string founder) => (name, founder) = (Name, Founder);

    }
}
