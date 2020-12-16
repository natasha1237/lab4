using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class Element
    {
        public string ElementName { get; }

        // Список сусідніх елементів.
        public List<Element> AdjacentEl { get; }

        public Element(string name)
        {
            ElementName = name;
            AdjacentEl = new List<Element>();
        }

        // Додає нову сусідню вершину.
        public Element AddAdjacentEl(Element Element, bool bidirect = true)
        {
            AdjacentEl.Add(Element);
            if (bidirect)
            {
                Element.AdjacentEl.Add(this);
            }
            return this;
        }
    }
}
