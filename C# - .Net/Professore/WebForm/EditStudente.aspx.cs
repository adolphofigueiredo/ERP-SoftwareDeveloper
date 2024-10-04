using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer.Models.Entities;
using BusinessLayer.Repositories;

public partial class EditStudente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var repoCorsi = new CorsiRepository();
        var corsi = repoCorsi.GetCorsiValidi(DateTime.Now);
        ddlCorso.DataSource = corsi.ToList();
        ddlCorso.DataValueField = nameof(CorsoEntity.Id);
        ddlCorso.DataTextField = nameof(CorsoEntity.Nome);
        ddlCorso.DataBind();

        string sId = string.Empty;
        try
        {
            sId = Request.QueryString["id"];
        }
        catch { /*non faccio nulla vorra dire che dovro inserire una nuova entita */}
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(sId))
            {
                StudentiRepository studentiRepository = new StudentiRepository();
                var studente = studentiRepository.Get(int.Parse(sId));
                hddId.Value = sId;
                txtNome.Text = studente.Nome;
                txtCognome.Text = studente.Cognome;
                txtCf.Text = studente.CodiceFiscale;
                ddlCorso.SelectedValue = studente.Nome;
                calDdn.SelectedDate = studente.DataDiNascita;
            }
        }
    }
}