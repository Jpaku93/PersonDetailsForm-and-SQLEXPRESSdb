using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonDetailsForm
{
    public partial class ViewPersonDetails : Form
    {
        public ViewPersonDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.DATAGET("SELECT * FROM PersonDetails");
            DataTable dt = new DataTable();
            cn.sda.Fill(dt);

            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["Id"].Value = n + 1;
                dataGridView1.Rows[n].Cells["FirstName"].Value = row["FirstName"].ToString();
                dataGridView1.Rows[n].Cells["LastName"].Value = row["LastName"].ToString();
                dataGridView1.Rows[n].Cells["StreetName"].Value = row["StreetName"].ToString();
                dataGridView1.Rows[n].Cells["Town_State"].Value = row["Town_State"].ToString();
                dataGridView1.Rows[n].Cells["City"].Value = row["City"].ToString();
                dataGridView1.Rows[n].Cells["Email"].Value = row["Email"].ToString();
                dataGridView1.Rows[n].Cells["ContactNumber"].Value = row["ContactNumber"].ToString();
                dataGridView1.Rows[n].Cells["Gender"].Value = row["Gender"].ToString();
                dataGridView1.Rows[n].Cells["DOB"].Value = Convert.ToDateTime(row["DOB"].ToString()).ToString("dd/MM/yyyy");
                dataGridView1.Rows[n].Cells["Marital"].Value = row["Marital"].ToString();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.DATAGET("SELECT * FROM PersonDetails Where DOB = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'");
            DataTable dt = new DataTable();
            cn.sda.Fill(dt);

            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["Id"].Value = n + 1;
                dataGridView1.Rows[n].Cells["FirstName"].Value = row["FirstName"].ToString();
                dataGridView1.Rows[n].Cells["LastName"].Value = row["LastName"].ToString();
                dataGridView1.Rows[n].Cells["StreetName"].Value = row["StreetName"].ToString();
                dataGridView1.Rows[n].Cells["Town_State"].Value = row["Town_State"].ToString();
                dataGridView1.Rows[n].Cells["City"].Value = row["City"].ToString();
                dataGridView1.Rows[n].Cells["Email"].Value = row["Email"].ToString();
                dataGridView1.Rows[n].Cells["ContactNumber"].Value = row["ContactNumber"].ToString();
                dataGridView1.Rows[n].Cells["Gender"].Value = row["Gender"].ToString();
                dataGridView1.Rows[n].Cells["DOB"].Value = Convert.ToDateTime(row["DOB"].ToString()).ToString("dd/MM/yyyy");
                dataGridView1.Rows[n].Cells["Marital"].Value = row["Marital"].ToString();
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.DATAGET("SELECT * FROM PersonDetails Where Gender = '" + comboBox1.Text + "'");
            DataTable dt = new DataTable();
            cn.sda.Fill(dt);

            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["Id"].Value = n + 1;
                dataGridView1.Rows[n].Cells["FirstName"].Value = row["FirstName"].ToString();
                dataGridView1.Rows[n].Cells["LastName"].Value = row["LastName"].ToString();
                dataGridView1.Rows[n].Cells["StreetName"].Value = row["StreetName"].ToString();
                dataGridView1.Rows[n].Cells["Town_State"].Value = row["Town_State"].ToString();
                dataGridView1.Rows[n].Cells["City"].Value = row["City"].ToString();
                dataGridView1.Rows[n].Cells["Email"].Value = row["Email"].ToString();
                dataGridView1.Rows[n].Cells["ContactNumber"].Value = row["ContactNumber"].ToString();
                dataGridView1.Rows[n].Cells["Gender"].Value = row["Gender"].ToString();
                dataGridView1.Rows[n].Cells["DOB"].Value = Convert.ToDateTime(row["DOB"].ToString()).ToString("dd/MM/yyyy");
                dataGridView1.Rows[n].Cells["Marital"].Value = row["Marital"].ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
