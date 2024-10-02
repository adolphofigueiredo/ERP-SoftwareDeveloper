using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using _20241001_BusinessLayer.Models.Dtos;
using _20241001_BusinessLayer.Models.Entities;
using _20241001_BusinessLayer.Models.Filters;
using _20241001_BusinessLayer.Models.Mappers;
using _20241001_BusinessLayer.Repositories;

public partial class StudentiList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRicerca_Click(object sender, EventArgs e)
    {
        StudentiRepository repository = new StudentiRepository();
        var filtro = new StudenteFilter
        {
            Nominativo = txtNominativo.Text,
            Inizio = null,
            Fine = null
        };
        if (calDataDiNascitaDa.SelectedDate != DateTime.MinValue) filtro.Inizio = calDataDiNascitaDa.SelectedDate;
        if (calDataDiNascitaA.SelectedDate != DateTime.MinValue) filtro.Fine = calDataDiNascitaA.SelectedDate;
        ICollection<StudenteEntity> studentiList = repository.Find(filtro);
        List<StudenteDto> studentiDto = studentiList.Select(r => StudenteMapper.Map(r)).ToList();
        grdRisultati.AutoGenerateColumns = true;
        grdRisultati.DataSource = studentiDto;
        grdRisultati.DataBind();
    }
}