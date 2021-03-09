using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Label lbl = new Label
            {
                Text = "Label_" + index,
                Location = new Point(100, 100 + index * 40),
                Size = new Size(100, 30),
                Name = "label_" + index,
                Font = new Font("Arial",10,FontStyle.Italic),
            };
            lbl.Click += new EventHandler(this.label1_Click);
            Controls.Add(lbl);
            index++;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = ((Label)sender).Text;
        }
    }
}
