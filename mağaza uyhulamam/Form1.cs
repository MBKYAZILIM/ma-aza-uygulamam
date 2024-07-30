namespace mağaza_uyhulamam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "")
                label6.Text = "0";
            else if (listBox1.Text == "UZUN KOL")
                label6.Text = "50";
            else if (listBox1.Text == "KISA KOL")
                label6.Text = "60";
            else if (listBox1.Text == "HAKİM YAKA ")
                label6.Text = "70";

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.Text == "")
                label7.Text = "0";
            else if (listBox2.Text == "KETEN")
                label7.Text = "90";
            else if (listBox2.Text == "KOT")
                label7.Text = "100";
            else if (listBox2.Text == "KUMAŞ")
                label7.Text = "110";

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.Text == "")
                label8.Text = "0";
            else if (listBox3.Text == "KOT")
                label8.Text = "150";
            else if (listBox3.Text == "DERİ")
                label8.Text = "200";
            else if (listBox3.Text == "KUMAŞ")
                label8.Text = "250";

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox4.Text == "")
                label9.Text = "0";
            else if (listBox4.Text == "SUNİ DERİ")
                label9.Text = "150";
            else if (listBox4.Text == "SPOR")
                label9.Text = "200";
            else if (listBox4.Text == "DERİ")
                label9.Text = "250";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam;
            listBox5.Items.Clear();


            if (listBox1.Text != "")
                listBox5.Items.Add("GÖMLEK" + listBox1.Text + " " + label6.Text);


            if (listBox2.Text != "")
                listBox5.Items.Add("PANTOLON" + listBox2.Text + " " + label7.Text);

            if (listBox3.Text != "")
                listBox5.Items.Add("CEKET" + listBox3.Text + " " + label8.Text);

            if (listBox4.Text != "")
                listBox5.Items.Add("AYAKKABI" + listBox4.Text + " " + label9.Text);
            toplam = int.Parse(label6.Text) + int.Parse(label7.Text) + int.Parse(label8.Text)
                + int.Parse(label9.Text);
            textBox1.Text = toplam.ToString();

        }
    }
}
