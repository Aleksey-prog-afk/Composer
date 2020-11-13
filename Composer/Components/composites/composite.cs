using System;
using System.Collections.Generic;
using System.Text;

namespace Composer.Components.composites
{
    abstract class composite : IComponent
    {
        protected List<IComponent> nodes;
        protected composite()
        {
            nodes = new List<IComponent>();
        }
        public void Add(IComponent component)
        {
            this.nodes.Add(component);
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
           int weight = 0;
           foreach(IComponent node in nodes)
            {
                weight += node.GetWeight();
            }
            return weight;
        }

        public bool IsComposite()
        {
           return true;
        }

        public void Remove(IComponent component)
        {
            this.nodes.Remove(component);
        }
        public void GetInfo()
        {
            Console.WriteLine("{0} {1}",this.GetName(), this.GetWeight());
            foreach(IComponent component in nodes)
            {
                this.GetInfo("\t", component);
            }

        }
        private void GetInfo(string prefix, IComponent component)
        {
            string str = prefix + component.GetName() + " " + component.GetWeight();
            Console.WriteLine(str);
            if (component.IsComposite())
            {
                foreach (IComponent comp in component.GetComponents())
                {
                    GetInfo(prefix + "\t", comp);
                }
            }
        }
        public List<IComponent> GetComponents()
        {
            return this.nodes;
        }
        
    }
}
