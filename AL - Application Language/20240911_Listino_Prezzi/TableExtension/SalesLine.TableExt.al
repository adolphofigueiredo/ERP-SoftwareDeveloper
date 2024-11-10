tableextension 50103 "Sales Line Ext" extends "Sales Line"
{
    fields
    {
        modify(Quantity)
        {
            trigger OnAfterValidate()
            var
                UnitPrice: Decimal;
                SalesLine: Record "Sales Line";
                SalePriceMgmt: Codeunit "Sales Price Management";
            begin
                if ((Rec.Quantity > 0) and (Rec.Type = Rec.Type::Item)) then begin       //If the row which I'm working on has a
                                                                                         //quantity greater than zero and is of type "Item". 
                    UnitPrice := SalePriceMgmt.GetSalesUnitPrice(Rec."Sell-to Customer No.", Rec."No.", Rec.Quantity); //So I will find
                                                                                                                       //the lowest price based on the customer, the
                                                                                                                       //item (No.), and the quantity.
                    if (UnitPrice > 0) then begin                                        //If a price has been found.
                                                                                         //Set the price in the Unit Price field of the
                                                                                         //row. This can't happen with a direct
                                                                                         //assignment but by validating the field.
                        Rec.Validate("Unit Price", UnitPrice);                           //I need to insert the comment line, but I cannot
                                                                                         //use Rec, because it’s the record that the user
                                                                                         //is currently working on, so I need to create a
                                                                                         //new variable, SalesLine, to insert the record
                        SalesLine.Init();                                                //fields.

                        SalesLine."Document Type" := Rec."Document Type";                //Starting by setting the record key.
                        SalesLine."Document No." := Rec."Document No.";                  //Starting by setting the record key.
                        SalesLine."Line No." := Rec."Line No." + 1;                      //Starting by setting the record key.

                        SalesLine.Type := SalesLine.Type::" ";                           //Then set the Type field an empty Type
                                                                                         //indicates that the line is a comment.

                        SalesLine.Description := 'Prezzo unitario dell''articolo ' + Rec."No." + ' scontato a ' + Format(Rec."Unit Price");
                        //The Description field is the comment itself, formatted with the item and the unit price of the line.
                        SalesLine.Insert();                                              //At the end, I need to call the insert
                                                                                         //function, otherwise, the record will not be
                                                                                         //saved to the database.
                    end
                end;
            end;
        }
    }
}