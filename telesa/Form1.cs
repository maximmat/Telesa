namespace telesa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typ = ""; //prom�nn� pro ur�en� vybran�ho t�lesa
            double delkaHrany = (double)numericUpDown1.Value;

            if (rbKrychle.Checked == true) typ = "krychle";
            else if (rbKoule.Checked == true) typ = "koule";
            else if (rbDvanactisten.Checked == true) typ = "dvanactisten";
            else if (rbDvacetisten.Checked == true) typ = "dvacetisten";

            var nTeleso = TelesoFactory.MakeTeleso(typ, delkaHrany); 
            listBox1.Items.Add(nTeleso); //p�id�n� vygenerovan�ho t�lesa do listBoxu
        }
    }
}
