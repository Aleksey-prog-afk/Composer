using Composer.Components.leafs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composer.Components.composites
{
    class Wheel : composite
    {
        public Wheel()
        {
            this.nodes.Add(new Disk());
            this.nodes.Add(new Tire());
        }
    }
}
