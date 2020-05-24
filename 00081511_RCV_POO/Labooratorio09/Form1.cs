using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labooratorio09
{
    public partial class Form1 : Form
    {
        private UserControl current = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Estudiante();
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetColumnSpan(current,4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Materia();
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetColumnSpan(current,4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Inscripcion();
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetColumnSpan(current,4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Detalle();
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetColumnSpan(current,4);
        }

        private void estudiante1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}