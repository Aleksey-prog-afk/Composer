using Composer.Components.leafs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composer.Components.composites
{
    class Differential : composite
    {
        public Differential()
        {
            this.nodes.Add(new Gears());
            this.nodes.Add(new Bearing());
            this.nodes.Add(new Shank());
        }
    }
}
