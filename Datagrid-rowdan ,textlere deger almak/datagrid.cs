           //DATAGRIDDEKI SECILI ROWUN ISTENILEN BOLUMUNU ALMAK
            id = (int)dataGridView1.CurrentRow.Cells["Ogrid"].Value;

            //TIKLANILAN ROWUN DEGERLERINI ALMAK

            DataGridViewRow row = dataGridView1.CurrentRow;
            txtID.Tag = row.Cells[0].Value; 
            txtID.Text = row.Cells[0].Value.ToString();
            if (row.Cells[1].Value!=null)
            {
                txtAd.Text = row.Cells[1].Value.ToString();
            }
           
            txtSoyad.Text = row.Cells[2].Value.ToString();
            txtKalanBorc.Text = row.Cells[3].Value.ToString();