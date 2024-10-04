using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using _20241001_BusinessLayer.Models.Dtos;
using _20241001_BusinessLayer.Models.Entities;
using _20241001_BusinessLayer.Models.Filters;
using _20241001_BusinessLayer.Models.Mappers;
using _20241001_BusinessLayer.Repositories;

public partial class StudentiList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)                                                              //A função IsPostBack evita que eu tenha que recarregar a pagina toda vez
                                                                                                   //que clico no botão, ou seja, faço menos conexoes ao banco de dados. Faço
                                                                                                   //a mesma coisa, mas carrego sem adicionar variaveis no filtro. é esta 
                                                                                                   //funçao boleana que retorno um valor dizendo se a pagina esta sendo acessada
                                                                                                   //pela primeira vez ou nao.
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

    protected void grdRisultati_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = grdRisultati.SelectedRow;
        Response.Redirect("EditStudente.aspx?id=");                                                //O GridViewRow é uma classe que representa uma linha individual em um controle
                                                                                                   //GridView. Cada linha contém dados, que podem ser acessados individualmente
                                                                                                   //através desta classe. O grdRisultati é o nome do controle GridView em sua
                                                                                                   //página, que deve exibir uma tabela com várias linhas de dados. O GridView é
                                                                                                   //um componente de interface usado para exibir e manipular dados em formato
                                                                                                   //tabular. O SelectedRow é uma propriedade do GridView que retorna a linha que
                                                                                                   //foi selecionada pelo usuário. Ela é do tipo GridViewRow, ou seja, você está
                                                                                                   //armazenando a linha selecionada pelo usuário na variável row. Isso permite
                                                                                                   //que você acesse os dados ou manipule a linha específica da tabela.
                                                                                                   //O Response.Redirect("EditStudente.aspx?id="); é um método que redireciona o
                                                                                                   //usuário para outra página no servidor. Neste caso, a página de destino é
                                                                                                   //EditStudente.aspx. Neste caso, o usuario está sendo redirecionado para a
                                                                                                   //página EditStudente.aspx, mas espera enviar um parâmetro id através da query
                                                                                                   //string (?id=). Entretanto, o valor do id é vazio.
    }
}