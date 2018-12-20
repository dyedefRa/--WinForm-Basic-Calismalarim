 try
            {
                int k = Convert.ToInt32(textBox1.Text);
                if (k < 45)
                {
                    MessageBox.Show("Kaldýnýz");
                }
                else if (k <= 100)
                {
                    MessageBox.Show("Geçtiniz");
                }
                else if (k > 100)
                {
                    try
                    {
                        throw new FormatException("Sayýnýzý 100den büyük girmeyin");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }

            }
            

            catch (OverflowException)
            {
                MessageBox.Show("INT32 DEN DISARI CIKTIN ");

            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sayý giriniz");
            }