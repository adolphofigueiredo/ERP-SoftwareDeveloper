using System;
using _20241001_BusinessLayer.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _20241001_BusinessLayer.Models.Entities;


public partial class EditStudente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)             //O Page_Load é carregado automaticamente, ninguém
                                                                     //precisa chamá-lo
    {
        var repoCorsi = new CorsoRepository();
        var corsi = repoCorsi.GetCorsiValidi(DateTime.Now);
        ddlCorso.DataSource = corsi.ToList();
        ddlCorso.DataValueField = nameof(CorsoEntity.Id);            //O operador nameof retorna o nome da propriedade Nome da
                                                                     //classe CorsoEntity como uma string. Isso é útil para
                                                                     //evitar erros de refatoração, pois o nome da propriedade
                                                                     //é fortemente tipado, e qualquer mudança no nome da
                                                                     //propriedade será refletida automaticamente.
        ddlCorso.DataTextField = nameof(CorsoEntity.Nome);
        ddlCorso.DataBind();

        string sId = string.Empty;

        try
        { 
            sId = Request.QueryString["id"];
        }
        catch
        {
        if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(sId))
                { 
                    StudentiRepository studentiRepository = new StudentiRepository();
                    var studente = studentiRepository.Get(int.Parse(sId));
                    hddId.Value = sId;
                    txtNome.Text = studente.Nome;
                    txtCognome.Text = studente.Cognome;
                    txtCodiceFiscale.Text = studente.CodiceFiscale;
                    ddlCorso.SelectedValue = studente.Nome;
                    calDataDiNascita.SelectedDate = studente.DataDiNascita;
                }
            }
        }
    }
}