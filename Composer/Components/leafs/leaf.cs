using System;
using System.Collections.Generic;
using System.Text;

namespace Composer.Components.leafs
{
    abstract class leaf : IComponent
    {
        protected int weight;
        public void Add(IComponent component)
        {
            Console.WriteLine("Not a composite");
        }

        public List<IComponent> GetComponents()
        {
            return null;
        }

        public void GetInfo()
        {

           Console.WriteLine("\t" + this.GetName() + " " + this.GetWeight());
        }

        public string GetName()
        {
            return this.GetType().Name;
        }

        public int GetQuantity()
        {
            throw new NotImplementedException();
        }

        public int GetWeight()
        {
            return this.weight;
        }

        public bool IsComposite()
        {
            return false;
        }

        public void Remove(IComponent component)
        {
            Console.WriteLine("Not a composite");
        }
    }
}
