int toplam = 0;
private void button1_Click(object sender, EventArgs e)
{
    int x = Convert.ToInt32(Interaction.InputBox("Sayý gir"));
    while (x > 0)
    {
        toplam += x % 10;

        textBox1.AppendText((x % 10).ToString());
        x = x / 10;
    }
    MessageBox.Show($"Toplam basamak deðeri = {toplam}");










}