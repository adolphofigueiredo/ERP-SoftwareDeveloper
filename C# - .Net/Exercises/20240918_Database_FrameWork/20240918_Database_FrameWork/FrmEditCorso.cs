using _20240918_Database_FrameWork.Models.Entity;
using _20240918_Database_FrameWork.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20240918_Database_FrameWork
{
    public partial class FrmEditCorso : Form
    {
        public FrmEditCorso()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            try
            {
                CorsoRepository repository = new CorsoRepository();
                repository.Post(new CorsoEntity
                {

                    Nome = txtNome.Text,
                    DataValiditaInizio = dtpDataInizio.Value,
                    DataValiditaFine = dtpDataFine.Value,

                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ooops, That is an error: {ex.Message}");
            }
            finally
            { 
                btnSave.Enabled = true;
            }
        }
    }
}
