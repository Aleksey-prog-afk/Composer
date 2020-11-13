using Composer.Components.leafs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composer.Components.composites
{
    class PistonSystem : composite
    {
        public PistonSystem()
        {
            this.nodes.Add(new Piston());
            this.nodes.Add(new Crankshaft());
            this.nodes.Add(new Link());
            this.nodes.Add(new Gasket());
        }
    }
}
