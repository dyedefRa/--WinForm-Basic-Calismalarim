  if(e.Button==MouseButtons.Right)
            {
                int rowindexi = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if(rowindexi>-1)
                {
                    dataGridView1.Rows[rowindexi].Selected = true;
                    index = Convert.ToInt32(dataGridView1.Rows[rowindexi].Cells[0].Value);

                }
            }
}