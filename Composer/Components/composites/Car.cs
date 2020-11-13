using Composer.Components.leafs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composer.Components.composites
{
    class Car : composite
    {
        public Car()
        {
            this.nodes.Add(new EngineV6());
            this.nodes.Add(new Wheel());
            this.nodes.Add(new Wheel());
            this.nodes.Add(new Wheel());
            this.nodes.Add(new Wheel());
            this.nodes.Add(new Transmission());
            this.nodes.Add(new Differential());
            this.nodes.Add(new Door());
            this.nodes.Add(new Door());
            this.nodes.Add(new Door());
            this.nodes.Add(new Door());
            this.nodes.Add(new GasTank());
        }
    }
}
