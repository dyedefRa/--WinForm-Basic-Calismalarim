 try
            {
                int k = Convert.ToInt32(textBox1.Text);
                if (k < 45)
                {
                    MessageBox.Show("Kald�n�z");
                }
                else if (k <= 100)
                {
                    MessageBox.Show("Ge�tiniz");
                }
                else if (k > 100)
                {
                    try
                    {
                        throw new FormatException("Say�n�z� 100den b�y�k girmeyin");
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
                MessageBox.Show("L�tfen say� giriniz");
            }