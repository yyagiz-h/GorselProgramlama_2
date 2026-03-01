namespace Çarpma_Tablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox[] listeler = { listBox1, listBox2, listBox3, listBox4, listBox5,
                           listBox6, listBox7, listBox8, listBox9, listBox10 };

            
            for (int i = 0; i < 10; i++)  
            {
                listeler[i].Items.Clear(); 

                for (int j = 1; j <= 10; j++) 
                {
                    listeler[i].Items.Add((i + 1) + " x " + j + " = " + ((i + 1) * j));
                }
            }
        }
    }
}
