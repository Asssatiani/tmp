using System;
using System.Windows.Forms;

namespace tmp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tmpTableTableAdapter.Fill(this.tmpDataSet1.tmpTable);
            
            this.dataGridView1.DataSource = this.tmpDataSet1.tmpTable;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.tmpTableTableAdapter.Update(this.tmpDataSet1.tmpTable);
        }
    }
}
