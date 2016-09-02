using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kx.KxCheckBoxCell.Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add(new KxCheckBoxColumn(dataGridView1) { Name = "SELECT" });
            var list = new List<AAA>();
            list.Add(new AAA() { X = "1", Y = "1" });
            list.Add(new AAA() { X = "2", Y = "2" });
            list.Add(new AAA() { X = "3", Y = "3" });
            dataGridView1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                label1.Text += "\n" + ((KxCheckBoxCell)item.Cells[0]).Checked;
            }
        }
    }

    public class AAA
    {
        public string X { get; set; }
        public string Y { get; set; }
    }
}
