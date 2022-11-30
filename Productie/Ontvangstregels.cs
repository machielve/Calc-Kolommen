COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaalstatus id], 

[Detail_Materiaalstatus_Bon].[Materiaaltype]<>"1" AND 
[Detail_Materiaalstatus_Bon].[Ontvangen]<>[$MaterialState.Onwaar])+


OUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaalstatus id], 

[Detail_Materiaalstatus_Bon].[Voorraadtype]=="1" AND 
[Detail_Materiaalstatus_Bon].[Ontvangen]<>[$MaterialState.Onwaar])