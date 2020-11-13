using Composer.Components.leafs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composer.Components.composites
{
    class ValueSystem : composite
    {
        public ValueSystem()
        {
            for (int i = 0; i < 24; i++)
            {
                this.nodes.Add(new Value());
            }
            this.nodes.Add(new Camshaft());
        }
    }
}
