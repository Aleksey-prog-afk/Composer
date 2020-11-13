using System;
using System.Collections.Generic;
using System.Text;

namespace Composer.Components
{
    interface  IComponent
    {
        public void Add(IComponent component);
        public void Remove(IComponent component);
        public int GetWeight();
        public int GetQuantity();
        public string GetName();
        public bool IsComposite();
        public void GetInfo();
        public List<IComponent> GetComponents();



    }
}
