using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Semestr_3
{
    delegate void NodeClicked(int x, int y);
    class PanelView : Panel, IView
    {
        public event NodeClicked NodeClicked;
        IModel model;
        public IModel Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public void UpdateView()
        {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Model == null) return;
            Graphics g = e.Graphics;
            foreach (Node n in Model.AllNodes)
            {
                g.DrawEllipse(n.ColorType, n.X - 10, n.Y - 10, 20, 20);
            }
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            NodeClicked(e.X, e.Y);
        }
    }
}
