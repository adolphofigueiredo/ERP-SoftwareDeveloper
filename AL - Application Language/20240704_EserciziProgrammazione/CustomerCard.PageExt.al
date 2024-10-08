pageextension 50017 "ITS Customer Card Extension" extends "Customer Card"
{
    trigger OnOpenPage()
    begin
        Message('Pagina Aperta - Card');
    end;
}