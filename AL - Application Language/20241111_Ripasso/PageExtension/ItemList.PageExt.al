pageextension 50100 ItemListExt extends "Item List"
{
    actions
    {
        addfirst(processing)
        {
            action(FindFirstItemByMESId)
            {
                Caption = 'Find First Item By MES Id';
                Image = Find;
                ApplicationArea = All;

                trigger OnAction()
                var
                    Item: Record Item;
                begin
                    Item.SetFilter("MES Id", '<>%1', '');       //Esta linha esta dizendo que no campo de descriçao do MES Id o valor deve ser diferente de vazio.
                    Item.FindFirst();
                    Message('Il primo articolo com mes id è: %1', Item.Description);
                end;

            }
            action(CreateMesId)
            {
                Caption = 'Create MES Id';
                ApplicationArea = All;
                trigger OnAction()
                var
                    Selected: Integer;
                    Item: Record Item;
                    Count: Integer;
                begin
                    Selected := StrMenu('10,20,30,40,50', 1, 'Seleziona il numero di articoli da modificare:');
                    if Selected = 0 then
                        exit;

                    Selected *= 10;

                    Item.SetRange("MES Id", '');

                    if Item.FindSet() then
                        repeat
                            Count += 1;
                            Item.Validate("MES Id", 'MESART' + Format(Count));      //A funçao format converte um inteiro em uma string.
                            Item.Modify();

                        until (Item.Next() = 0) or (Count = Selected);

                    Message('%1 Articoli modificati', Count);
                end;
            }
        }
    }
}