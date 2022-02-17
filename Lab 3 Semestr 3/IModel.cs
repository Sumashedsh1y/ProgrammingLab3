using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Semestr_3
{
    public interface IModel
    {
        event Action Changed;

        IEnumerable<Node> AllNodes { get; }

        int Count { get; }

        void AddNode(Pen value);

        void RemoveNode(Node value);

        void RemoveLastNode();

        void ChangeColor(int x, int y);

    }
}
