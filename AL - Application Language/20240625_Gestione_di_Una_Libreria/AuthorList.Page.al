page 50100 "ITS Author List"    //usar o comando tpage -> list para criar uma pagina pre formatada
{
    Caption = 'Author List';
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;      //Aqui é onde se diz se vai ou nao aparecer no menu do business central
    SourceTable = "ITS Author";

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("No."; Rec."No.") //Rec. quer dizer record do sourcetable que nesta pagina é ITS Author.
                {
                    ApplicationArea = All; //é utilizado para fazer com que o campo serja visivel.
                }
                field(Name; Rec.Name) //Rec. também é uma variavel global.
                {
                    ApplicationArea = All; //é utilizado para fazer com que o campo serja visivel.
                }
                field("Country Code"; Rec."Country Code")
                {
                    ApplicationArea = All; //é utilizado para fazer com que o campo serja visivel.
                }
                field("Country Name"; Rec."Country Name")
                {
                    ApplicationArea = All; //é utilizado para fazer com que o campo serja visivel.
                }
            }
        }
        area(Factboxes) //factbox sao as partes pequenas que ficam a direita do business central.
        {
            systempart(Links; Links)            //prara procurar formulas é possivel ir no AL
            {                                   //Explorer e copiar um pedaço do codigo que 
                ApplicationArea = RecordLinks;  //preciso, mas antes é preciso encontar que tabela
                Visible = false;                //quero pesquisar no business central
            }
            systempart(Notes; Notes)
            {
                ApplicationArea = Notes;
                Visible = true;
            }
        }
    }
}