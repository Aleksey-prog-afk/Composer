using Composer.Components.leafs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composer.Components.composites
{
    class Door : composite
    {
        public Door()
        {
            this.nodes.Add(new Glass());
            this.nodes.Add(new DoorCard());
        }
    }
}
