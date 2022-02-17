using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_Semestr_3
{
    public partial class Form1 : Form, IController
    {
        static Random r = new Random();
        private IModel model;
        public Form1()
        {
            InitializeComponent();

            model = new MyModel();

            IView labView = new LabelView(label1);

            myDataGridView1.Model = model;
            AddView(myDataGridView1);

            labView.Model = model;
            AddView(labView);

            panel1.Model = model;

            AddView(panel1);

            panel1.NodeClicked += (int X, int Y) => { Model.ChangeColor(X, Y); };
        }
        public IModel Model
        {
            get
            { return model; }
            set
            { model = value; }
        }
        public void Add()
        {
            model.AddNode(Pens.Red);

        }
        public void AddView(IView v)
        {
            model.Changed += new Action(v.UpdateView);
        }

        public void Remove()
        {
            if (model.Count > 0)
                model.RemoveLastNode();
        }
        private void Click_Add(object sender, EventArgs e)
        {
            Add();
        }

        private void Click_Remove(object sender, EventArgs e)
        {
            Remove();
        }
        private void myDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void PanelView1_NodeClicked(Node node)
        {
            
        }
    }
}
