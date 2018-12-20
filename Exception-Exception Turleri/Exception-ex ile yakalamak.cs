 try
            {
                int k = Convert.ToInt32(textBox1.Text);
                if(k<45)
                    MessageBox.Show("Kaldýnýz");
                else if(k<=100)
                    MessageBox.Show("Geçtin");
                else if (k>100)
                    throw new OverflowException();

            }
            catch (Exception ex)
            {

               if(ex is OverflowException)
                {
                    ex.Data["stringInfo"] = "100den büyük bir sayý girdin baboþ";
                    ex.Data["time"] = DateTime.Now;


                   

                }
               else if ( ex is FormatException)
                {
                    ex.Data["stringInfo"] = "Format hatasý";
                    ex.Data["time"] = DateTime.Now;
                }
                else if (ex is FormatException)
                {
                    ex.Data["stringInfo"] = "Format hatasý";
                    ex.Data["time"] = DateTime.Now;
                }

                foreach (DictionaryEntry bilgi in ex.Data)
                {
                    listBox1.Items.Add(bilgi.Value.ToString());
                }

            }