using _20241001_BusinessLayer.Models.Dtos;
using _20241001_BusinessLayer.Models.Entities;
using _20241001_BusinessLayer.Models.Filter;
using _20241001_BusinessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using _20241001_BusinessLayer.Models.Mappers;



public partial class CorsiList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRicerca_Click(object sender, EventArgs e)
    {

        CorsoRepository repository = new CorsoRepository();
        var filtro = new CorsoFilter
        {


            NominativoCorso = txtNominativoCorso.Text,
            InizioCorsoDa = null,
            InizioCorsoA = null,
            FineCorsoDa = null,
            FineCorsoA = null
        };

        if (calInizioCorsoDa.SelectedDate != DateTime.MinValue) filtro.InizioCorsoDa = calInizioCorsoDa.SelectedDate;

        if (calInizioCorsoA.SelectedDate != DateTime.MinValue) filtro.InizioCorsoA = calInizioCorsoA.SelectedDate;

        if (calFineCorsoDa.SelectedDate != DateTime.MinValue) filtro.FineCorsoDa = calFineCorsoDa.SelectedDate;

        if (calFineCorsoA.SelectedDate != DateTime.MinValue) filtro.FineCorsoA = calFineCorsoA.SelectedDate;

        ICollection<CorsoEntity> corsiList = repository.Find(filtro);
        List<CorsoDto> corsiDto = corsiList.Select(c => CorsoMapper.Map(c)).ToList();
                                                                                                //Aqui, é declarada uma nova lista chamada corsiDto, do tipo List<CorsoDto>.
                                                                                                //Essa lista vai armazenar objetos do tipo CorsoDto, que é um Data Transfer Object.
                                                                                                //O CorsoDto é usado para transportar dados entre a camada de acesso a dados e a
                                                                                                //camada de apresentação, geralmente contendo apenas as informações necessárias para
                                                                                                //exibir na interface do usuário. O corsoList.Select(r => CorsoMapper.Map(r)) é
                                                                                                //um método onde o Select é uma operação de LINQ que projeta cada elemento da lista
                                                                                                //corsoList em um novo formato, o r => CorsoMapper.Map(r) é a parte da expressão
                                                                                                //que recebe cada CorsoEntity da corsoList(representado por r) e chama o método
                                                                                                //Map da classe CorsoMapper. O método Map converte um objeto CorsoEntity em um
                                                                                                //objeto CorsoDto, extraindo as propriedades necessárias e ignorando quaisquer que
                                                                                                //não são necessárias para a visualização. O ToList() materializa, quando é chamado
                                                                                                //novamente executa a projeção da consulta e cria uma lista de CorsoDto a partir
                                                                                                //dos resultados do Select.

          grdRisultati.AutoGenerateColumns = true;                              //O DataGridView automaticamente cria colunas e popula as linhas com os dados
                                                                                                   //fornecidos na coleção. Isso torna o processo de exibição de dados muito eficiente e
                                                                                                   //reduz a quantidade de código necessário para configurar o controle. O studentiDto é
                                                                                                   //uma lista ou coleção de objetos do tipo StudenteDto. O StudenteDto é um Data Transfer
                                                                                                   //Object(DTO) que representa os dados do estudante de forma simplificada e otimizada
                                                                                                   //para a transferência, frequentemente utilizado para evitar o acoplamento direto com
                                                                                                   //a camada de entidade(StudenteEntity). Esta coleção contém dados que foram filtrados
                                                                                                   //e mapeados a partir da consulta ao banco de dados, conforme a lógica definida
                                                                                                   //anteriormente.

        grdRisultati.DataSource = corsiDto;                                   //A DataSource é uma propriedade do DataGridView que define a origem dos dados que o
                                                                                   //controle deve exibir. Ao definir esta propriedade, você informa ao DataGridView de

        grdRisultati.DataBind();
    }

}