private void Form1_Load(object sender, EventArgs e)
{
    KnownColor sa = new KnownColor();
    for (sa = KnownColor.ActiveBorder; sa < KnownColor.YellowGreen; sa++)
    {
        listBox1.Items.Add(sa);
    }
}

private void listBox1_Click(object sender, EventArgs e)
{
    this.BackColor = ColorTranslator.FromHtml(listBox1.Text);
}