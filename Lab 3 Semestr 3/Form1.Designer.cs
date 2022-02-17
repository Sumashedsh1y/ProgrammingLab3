
namespace Lab_3_Semestr_3
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.myDataGridView1 = new Lab_3_Semestr_3.MyDataGridView();
            this.panel1 = new Lab_3_Semestr_3.PanelView();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Click_Add);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(389, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Click_Remove);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Aharoni", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(254, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myDataGridView1
            // 
            this.myDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView1.Location = new System.Drawing.Point(603, 13);
            this.myDataGridView1.Model = null;
            this.myDataGridView1.Name = "myDataGridView1";
            this.myDataGridView1.RowHeadersWidth = 30;
            this.myDataGridView1.RowTemplate.Height = 30;
            this.myDataGridView1.Size = new System.Drawing.Size(467, 530);
            this.myDataGridView1.TabIndex = 4;
            this.myDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myDataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 102);
            this.panel1.Model = null;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 441);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 555);
            this.Controls.Add(this.myDataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "MVC";
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private PanelView panel1;
        private MyDataGridView myDataGridView1;
    }
}

