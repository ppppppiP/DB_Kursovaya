using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Kursovaya
{
    public partial class Form2 : Form
    {
        StrahovieEntities db;
        public Form2()
        {
            db = new StrahovieEntities();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.iskTableAdapter.Fill(this.strahovieDataSet.Isk);
            this.clientTableAdapter.Fill(this.dataSet1.Client);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Isk isk = new Isk();
            isk.Isk_Statuse = textBox4.Text;
            isk.Isk_date = DateTime.Parse(dateTimePicker1.Text);
            isk.Isk_number = Convert.ToInt32(textBox1.Text);
            isk.Isk_Summ = Convert.ToInt32(textBox3.Text);
            db.Isk.Add(isk);
            db.SaveChanges();
        }
    }
}
