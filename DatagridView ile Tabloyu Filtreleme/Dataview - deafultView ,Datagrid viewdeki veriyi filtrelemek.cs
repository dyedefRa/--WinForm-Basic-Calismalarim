 private void textBox1_TextChanged(object sender, EventArgs e)
        {

            DataView dv = dt.DefaultView;
            dv.RowFilter = $" Ad like '%{textBox1.Text}%'";

            dataGridView1.DataSource = dv;
          
        }