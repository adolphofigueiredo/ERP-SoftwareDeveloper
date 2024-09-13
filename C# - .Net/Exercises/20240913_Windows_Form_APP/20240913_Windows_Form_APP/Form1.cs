namespace _20240913_Windows_Form_APP
{
    public partial class frmEsempio : Form
    {
        public frmEsempio()
        {
            InitializeComponent();
        }
        private void btnSaluta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + txtNominativo.Text);
        }
        private void txtNominativo_TextChanged(object sender, EventArgs e)
        {
            if(txtNominativo.Text.Length > 3)
                btnSaluta.Enabled = true;
            else
                btnSaluta.Enabled = false;
//btnSaluta.Enabled = txtNominativo.Text.Length > 3; - This line is optimizing all four lines above.
        }
    }
}