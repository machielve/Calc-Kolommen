If(COUNT([Detail_Offertedocumenten_Document].[Offertedocument ID])>0,                           "Verkoop offerte ", "")+
If(COUNT([Detail_Documenten van order_Document].[Documenten van order ID])>0,                   "Verkoop order ", "")+
If(COUNT([Detail_Documenten Inkooporder_Documenten].[Documents of Purchase order ID])>0,        "Inkoop order ", "")+
If(COUNT([Detail_Documenten van afwijking_Document].[Document van afwijking id])>0,             "Afwijking ", "")+
If(COUNT([Detail_Documenten of Sales invoice_Document].[Documenten of Sales invoice ID])>0,     "Verkoop factuur ", "")+
If(COUNT([Detail_Relatiedocumenten_Document].[Relatiedocument ID])>0,                           "Relatie document ", "")