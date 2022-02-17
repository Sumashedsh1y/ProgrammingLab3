using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Semestr_3
{
    class MyModel : IModel
    {
        private static Random r = new Random();
        private LinkedList<Node> nodes = new LinkedList<Node>();

        public IEnumerable<Node> AllNodes => nodes;
        public int Count => nodes.Count;

        public event Action Changed;

        public void AddNode(Pen value)
        {
            nodes.AddFirst(new Node(value, r.Next(50,500), r.Next(50,400)));
            if (Changed != null) Changed();
        }

        public void RemoveNode(Node node)
        {
            nodes.Remove(node);
            if (Changed != null) Changed();
        }
        public void RemoveLastNode()
        {
            nodes.RemoveLast();
            if (Changed != null) Changed();
        }
        public void ChangeColor(int x, int y)
        {
            List<Node> temp = new List<Node>(nodes);
            for (int i = 0; i < nodes.Count; i++)
            {
                double lenght = Math.Sqrt(Math.Pow(temp[i].X - x, 2) + Math.Pow(temp[i].Y - y, 2));
                if (lenght <= 10)
                {
                    temp[i].ColorType = Pens.Blue;
                    for (int j = 0; j < nodes.Count; j++)
                    {
                        double lenght_circles = Math.Sqrt(Math.Pow(temp[i].X - temp[j].X, 2) + Math.Pow(temp[i].Y - temp[j].Y, 2));
                        if (lenght_circles <= 21)
                        {
                            temp[j].ColorType = Pens.Blue;
                        }
                    }
                }

            }
            if (Changed != null) Changed();
        }
    }
}
