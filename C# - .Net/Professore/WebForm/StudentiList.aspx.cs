using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using BusinessLayer.Models.Dtos;
using BusinessLayer.Models.Entities;
using BusinessLayer.Models.Filters;
using BusinessLayer.Models.Mappers;
using BusinessLayer.Repositories;

public partial class StudentiList : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            StudentiRepository repository = new StudentiRepository();
            var filtro = new StudenteFilter
            {

            };
            ICollection<StudenteEntity> studentiList = repository.Find(filtro);
            List<StudenteDto> studentiDto = studentiList.Select(r => StudenteMapper.Map(r)).ToList();
            grdRisultati.AutoGenerateColumns = true;
            grdRisultati.DataSource = studentiDto;
            grdRisultati.DataBind();
        }
    }

    protected void btnRicerca_Click(object sender, EventArgs e)
    {
        StudentiRepository repository = new StudentiRepository();
        var filtro = new StudenteFilter
        {
            Nominativo = txtNominativo.Text,
            Da = null,
            A = null
        };

        if (calDataDiNascitaDa.SelectedDate != DateTime.MinValue) filtro.Da = calDataDiNascitaDa.SelectedDate;
        if (calDataDiNascitaA.SelectedDate != DateTime.MinValue) filtro.A = calDataDiNascitaA.SelectedDate;

        ICollection<StudenteEntity> studentiList = repository.Find(filtro);
        List<StudenteDto> studentiDto = studentiList.Select(r => StudenteMapper.Map(r)).ToList();
        grdRisultati.AutoGenerateColumns = true;
        grdRisultati.DataSource = studentiDto;
        grdRisultati.DataBind();
    }

    protected void grdRisultati_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = grdRisultati.SelectedRow;
        Response.Redirect($"EditStudente.aspx?id=");
    }
}