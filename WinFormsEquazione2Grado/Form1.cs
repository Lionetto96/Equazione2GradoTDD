
using Equazione2Grado_Core;

namespace WinFormsEquazione2Grado
{
    public partial class Equazione2Grado : Form
    {
        double valueA;
        double valueB;
        double valueC;
        
        Equazione eq = new Equazione();
        public Equazione2Grado()
        {
            InitializeComponent();
        }

       
     

        private void btnRisolvi_Click(object sender, EventArgs e)
        {
            valueA = double.Parse(textBox1.Text);
            valueB = double.Parse(textBox2.Text);
            valueC = double.Parse(textBox3.Text);

            double[] risultato = eq.RisolviEquazioneDiSecondoGrado(valueA, valueB, valueC);
            //con operatore ternario
            textBox4.Text = (risultato == null) ? "errore" : (risultato.Length==1) ? risultato[0].ToString() : $"x1={risultato[0]} x2={risultato[1]}" ;
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Digit(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')){
                e.Handled = true;

            }
            if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.')> -1))
            {
                e.Handled=true;
            }

        }
    }
}