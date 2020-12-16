using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab4
{
    class Algorithm
    {
        // Список посещенных вершин
        private HashSet<Element> visited;
        // Путь из начальной вершины в целевую.
        private LinkedList<Element> path;
        private Element goal;

        public LinkedList<Element> A1(Element start, Element goal)
        {
            visited = new HashSet<Element>();
            path = new LinkedList<Element>();
            this.goal = goal;
            A1(start);
            if (path.Count > 0)
            {
                path.AddFirst(start);
            }
            return path;
        }

        private bool A1(Element Element)
        {
            if (Element == goal)
            {
                return true;
            }
            visited.Add(Element);
            foreach (var item in Element.AdjacentEl.Where(x => !visited.Contains(x)))
            {
                if (A1(item))
                {
                    path.AddFirst(item);
                    return true;
                }
            }
            return false;
        }
    }
}
