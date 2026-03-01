namespace Hesap_Makinası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayi1 = 0;
        string islem = "";
        private void button10_Click(object sender, EventArgs e)
        {
            double sayi2 = Convert.ToDouble(textBox1.Text);
            double sonuc = 0;

            if (islem == "+")
                sonuc = sayi1 + sayi2;

            if (islem == "-")
                sonuc = sayi1 - sayi2;

            if (islem == "*")
                sonuc = sayi1 * sayi2;

            if (islem == "/")
                sonuc = sayi1 / sayi2;

            label1.Text = "Sonuç: " + sonuc.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            sayi1 = Convert.ToDouble(textBox1.Text);
            islem = btn.Text;
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            sayi1 = Convert.ToDouble(textBox1.Text);
            islem = btn.Text;
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            sayi1 = Convert.ToDouble(textBox1.Text);
            islem = btn.Text;
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            sayi1 = Convert.ToDouble(textBox1.Text);
            islem = btn.Text;
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();     
            label1.Text = "";      

            sayi1 = 0;             
            islem = "";            
            
        }
    }
}
