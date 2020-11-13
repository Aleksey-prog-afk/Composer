using Composer.Components.leafs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composer.Components.composites
{
    class EngineV6 : composite
    {
        public EngineV6()
        {
            this.nodes.Add(new PistonSystem());
            this.nodes.Add(new ValueSystem());
            this.nodes.Add(new IntakeManifold());
            this.nodes.Add(new ExhaustManifold());
            this.nodes.Add(new Radiator());
        }
    }
}
