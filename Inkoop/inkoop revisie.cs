"/ "+convertinttostring 

(COUNTCONDITION([Detail_Documenten Inkooporder_Inkooporder].[Documents of Purchase order ID], 
[Detail_Documenten Inkooporder_Inkooporder].[Documenten].[Extensie]==".pdf" AND Left([Detail_Documenten Inkooporder_Inkooporder].[Documenten].[Omschrijving], 8)=="Purchase")+

COUNTCONDITION([Detail_Documenten Inkooporder_Inkooporder].[Documents of Purchase order ID],
[Detail_Documenten Inkooporder_Inkooporder].[Documenten].[Extensie]==".pdf" AND Left([Detail_Documenten Inkooporder_Inkooporder].[Documenten].[Omschrijving], 11)=="Inkooporder")+

COUNTCONDITION([Detail_Documenten Inkooporder_Inkooporder].[Documents of Purchase order ID], 
[Detail_Documenten Inkooporder_Inkooporder].[Documenten].[Extensie]==".pdf" AND Left([Detail_Documenten Inkooporder_Inkooporder].[Documenten].[Omschrijving], 17)=="Einkaufbestellung"))

-1)