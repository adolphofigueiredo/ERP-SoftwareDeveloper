using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsempioWinForm
{
    public partial class Form1 : Form
    {
        int? temp = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Numeri_click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) throw new Exception("Numeri_click deve essere associato ad un bottone!");
            txtInput.Text += btn.Text;
        }

        private void Operazione_click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) throw new Exception("Operazione_click deve essere associato ad un bottone!");

            bool parseResult = int.TryParse(txtInput.Text, out int intInput);
            if(!parseResult) throw new Exception("Input non corretto!");

            lblRisultato.Text = intInput.ToString();
            switch (btn.Text)
            {
                case "+": break;
                    
                case "-": break;
                case "*": break;
                case "/": break;
                case "=": break;
            }
        }

    }
}
