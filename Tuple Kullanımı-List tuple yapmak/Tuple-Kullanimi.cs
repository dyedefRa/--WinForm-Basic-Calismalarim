List<int> a = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            Tuple<int, string, bool> melaba = new Tuple<int, string, bool>(5, "ali", true);
            List<Tuple<int, string, bool>> Listem = new List<Tuple<int, string, bool>>();
            Listem.Add(new Tuple<int, string, bool>(123, "memo", false));
            int x = melaba.Item1;
         //   MessageBox.Show(x.ToString());
            Listem.Add(new Tuple<int, string, bool>(2, "sad", true));
            int k=Listem[1].Item1;
            
            foreach (var item in Listem)
            {
                a.Add(item.Item1);
            }
            int p = a.Count();
            for (int i = 0; i < p; i++)
            {
                label1.Text += Convert.ToInt32(a[i]);

            }
            }