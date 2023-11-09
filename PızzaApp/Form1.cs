namespace PızzaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }















        private void button1_Click(object sender, EventArgs e)
        {
            int toplamFiyat = 45;

            if (radioKalınHamur.Checked == true)
            {
                toplamFiyat += 10;
            }
            else if (radioNormalHamur.Checked == true)
            {
                
            }
            else if (radioİnceHamur.Checked == true)
            {
                
            }



            /*  if (radioAcıSos.Checked == true)
            {
                
            }
            else if (radioBarbekuSos.Checked == true)
            {
                toplamFiyat += 25;
            }
            else if (radioSarımsakSos.Checked == true)
            {
                toplamFiyat += 15;
            } */

            if(radioBarbekuSos.Checked == true)
            {
                toplamFiyat += 25;

            }
            if(radioSarımsakSos.Checked == true)
            {
                toplamFiyat += 15;
            }else if (radioAcıSos.Checked == true)
            {

            }




            else if (checkZeytin.Checked == true)
            {
                 toplamFiyat = toplamFiyat + 15;
            }
            if (checkMısır.Checked == true)
            {
                 toplamFiyat = toplamFiyat + 10;
            }
            if (checkSosis.Checked == true)
            {
                 toplamFiyat = toplamFiyat + 25;
            }
            if (checkJanbon.Checked == true)
            {
                 toplamFiyat = toplamFiyat + 18;
            }

            textBox1.Text = toplamFiyat.ToString(); 
        }
    }
}