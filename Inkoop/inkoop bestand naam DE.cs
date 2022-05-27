if([Pre-order]==1,"Pre-order "+ConvertIntTostring([Inkoopordernummer])+

if(
COUNTCONDITION([Detail_Documenten Inkooporder_Inkooporder].[Documents of Purchase order ID], 
[Detail_Documenten Inkooporder_Inkooporder].[Documenten].[Extensie]==".pdf" AND Left([Detail_Documenten Inkooporder_Inkooporder].[Documenten].[Omschrijving], 9)=="Pre-order")>0,

" Rev." + 
ConvertIntToString(
COUNTCONDITION( 
[Detail_Documenten Inkooporder_Inkooporder].[Documents of Purchase order ID], 
[Detail_Documenten Inkooporder_Inkooporder].[Documenten].[Extensie]==".pdf" AND Left([Detail_Documenten Inkooporder_Inkooporder].[Documenten].[Omschrijving], 9)=="Pre-order"))

,""),

"Inkooporder "+ConvertIntTostring([Inkoopordernummer])+
if(
COUNTCONDITION([Detail_Documenten Inkooporder_Inkooporder].[Documents of Purchase order ID], 
[Detail_Documenten Inkooporder_Inkooporder].[Documenten].[Extensie]==".pdf" AND Left([Detail_Documenten Inkooporder_Inkooporder].[Documenten].[Omschrijving], 17)=="Einkaufbestellung")>0,

" Rev" + 
ConvertIntToString(
COUNTCONDITION( 
[Detail_Documenten Inkooporder_Inkooporder].[Documents of Purchase order ID], 
[Detail_Documenten Inkooporder_Inkooporder].[Documenten].[Extensie]==".pdf" AND Left([Detail_Documenten Inkooporder_Inkooporder].[Documenten].[Omschrijving], 17)=="Einkaufbestellung"))
,"")






)