using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Semestr_3
{
    public class Node
    {
        private int x, y;
        public Pen color = Pens.Red;

        public Node(Pen color, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }

        public int X { get => x; }
        public int Y { get => y; }
        public string Color { get => color.Color.ToString(); }
        public Pen ColorType { get => color; set => color = value; }
    }
}
