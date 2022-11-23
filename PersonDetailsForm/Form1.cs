namespace PersonDetailsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the values from the text boxes and make sure datetime is not todays date and combo box is not empty
            if (string.IsNullOrEmpty(richTextBox1.Text) || 
                string.IsNullOrEmpty(richTextBox2.Text) || 
                string.IsNullOrEmpty(richTextBox3.Text) || 
                string.IsNullOrEmpty(richTextBox4.Text) || 
                string.IsNullOrEmpty(richTextBox5.Text) || 
                string.IsNullOrEmpty(richTextBox6.Text) || 
                string.IsNullOrEmpty(richTextBox7.Text) ||
                dateTimePicker1.Value == DateTime.Today ||
                comboBox1.SelectedItem == null ||
                comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                Connection cn = new Connection();

                cn.DATASEND(@"INSERT INTO PersonDetails (FirstName, LastName, StreetName, Town_State, City, Email, ContactNumber, Gender, DOB, Marital)
                    VALUES ('" + richTextBox1.Text + "','" + richTextBox2.Text + "','" + richTextBox3.Text + "','" + richTextBox4.Text + "','" + richTextBox5.Text + "','" + richTextBox6.Text + "','" + richTextBox7.Text + "','" + comboBox1.SelectedItem + "','" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "','" + comboBox2.SelectedItem + "')");

                MessageBox.Show("Data Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }
        void Clear()
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox5.Clear();
            richTextBox6.Clear();
            richTextBox7.Clear();
            dateTimePicker1.Value = DateTime.Today;
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
                
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox2.Focus();
            }
        }

        private void richTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox3.Focus();
            }
        }

        private void richTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox4.Focus();
            }
        }

        private void richTextBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox5.Focus();
            }
        }

        private void richTextBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox6.Focus();
            }
        }

        private void richTextBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox7.Focus();
            }
        }

        private void richTextBox7_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonDetailsForm.ViewPersonDetails VPD = new ViewPersonDetails();
            VPD.StartPosition = FormStartPosition.CenterScreen;
            VPD.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}