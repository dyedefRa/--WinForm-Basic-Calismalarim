 try
            {
                int k = Convert.ToInt32(textBox1.Text);
                if(k<45)
                    MessageBox.Show("Kald�n�z");
                else if(k<=100)
                    MessageBox.Show("Ge�tin");
                else if (k>100)
                    throw new OverflowException();

            }
            catch (Exception ex)
            {

               if(ex is OverflowException)
                {
                    ex.Data["stringInfo"] = "100den b�y�k bir say� girdin babo�";
                    ex.Data["time"] = DateTime.Now;


                   

                }
               else if ( ex is FormatException)
                {
                    ex.Data["stringInfo"] = "Format hatas�";
                    ex.Data["time"] = DateTime.Now;
                }
                else if (ex is FormatException)
                {
                    ex.Data["stringInfo"] = "Format hatas�";
                    ex.Data["time"] = DateTime.Now;
                }

                foreach (DictionaryEntry bilgi in ex.Data)
                {
                    listBox1.Items.Add(bilgi.Value.ToString());
                }

            }