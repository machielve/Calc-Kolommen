"RE: "+
If([Taal].[Code]=="NL", "Offerte aanvraag: ", 
If([Taal].[Code]=="EN", "Request for quotation: ", 
If([Taal].[Code]=="DE", "Angebotsanfrage: ", 
 "")))+
[Referentie]