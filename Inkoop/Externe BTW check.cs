If(
[Leverancier].[Bezoekadres].[Land].[Code]==[Los adres].[Adres].[Land].[Code] AND 
[Los adres].[Adres].[Land].[Code]<>"NL" AND
COUNTCONDITION([Detail_Inkooporderregel divers_Inkooporder].[Inkooporderregel divers id],[Detail_Inkooporderregel divers_Inkooporder].[Diversen].[Code]=="TT020")==0, 
"TT020 BTW post nodig", 
"")