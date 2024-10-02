using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.Models;
using BusinessLayer.Models.Entities;
using BusinessLayer.Models.Filters;
using BusinessLayer.Models.Mappers;
using BusinessLayer.Repositories;

namespace DbExplorer_WinApp
{
    public partial class FrmEntityFrameworkExample : Form
    {
        public FrmEntityFrameworkExample()
        {
            InitializeComponent();
        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            btnCheckConnection.Enabled = false;
            try
            {
                if (CheckConnectionUtility.CheckConnectionString(txtConnectionString.Text))
                    MessageBox.Show("Connessione OK");
                else
                    MessageBox.Show("Connessione KO");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
            finally
            {
                btnCheckConnection.Enabled = true;
            }
        }

        private void btnCercaStudenti_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConnectionString.Text)) throw new Exception("Connectionstring vuota!");
            btnCercaStudenti.Enabled = false;
            try
            {
                StudentiRepository studentiRepository = new StudentiRepository();
                var studentiList = studentiRepository.Find(new StudenteFilter());
                dgvStudentiList.AutoGenerateColumns = true;
                dgvStudentiList.DataSource = studentiList.Select(r => StudenteMapper.Map(r)).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"OPS, si è verificato un errore: {ex.Message}");
            }
            finally
            {
                btnCercaStudenti.Enabled = true;
            }
        }

        private void btnCercaCorsi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConnectionString.Text)) throw new Exception("Connectionstring vuota!");
            btnCercaStudenti.Enabled = false;
            try
            {
                CorsiRepository corsiRepository = new CorsiRepository();
                var corsiList = corsiRepository.Find(new CorsoFilter());
                dgvCorsiList.AutoGenerateColumns = true;
                dgvCorsiList.DataSource = corsiList.Select(r => CorsoMapper.Map(r)).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"OPS, si è verificato un errore: {ex.Message}");
            }
            finally
            {
                btnCercaStudenti.Enabled = true;
            }
        }
    }
}
