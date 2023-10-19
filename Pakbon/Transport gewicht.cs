If([Transport].[Laad relatie]==395,
    
    SUMCONDITION(
    [Transport].[Detail_Inkooporderregel divers_Inkooporder].[Aantal],
    [Transport].[Detail_Inkooporderregel divers_Inkooporder].[Detail_Alle reserveringen_Inkooporderregel divers].[Bonregel divers].[Bon]==[Bon] AND 
    [Transport].[Detail_Inkooporderregel divers_Inkooporder].[Diversen].[Code]=="T0002"),0.0)+



If([Transport].[Laad relatie]==7,
    
    SUMCONDITION(
    [Transport].[Detail_Inkooporderregel divers_Inkooporder].[Aantal],
    [Transport].[Detail_Inkooporderregel divers_Inkooporder].[Detail_Alle reserveringen_Inkooporderregel divers].[Bonregel divers].[Bon]==[Bon] AND 
    [Transport].[Detail_Inkooporderregel divers_Inkooporder].[Diversen].[Code]=="T0003"),0.0)+


If([Transport].[Laad relatie]==548,
    
    SUMCONDITION(
    [Transport].[Detail_Inkooporderregel divers_Inkooporder].[Aantal], 
    [Transport].[Detail_Inkooporderregel divers_Inkooporder].[Detail_Alle reserveringen_Inkooporderregel divers].[Bonregel divers].[Bon]==[Bon] AND
    [Transport].[Detail_Inkooporderregel divers_Inkooporder].[Diversen].[Code]=="T0004"),0.0)+

If([Transport].[Laad relatie]==421,
    
    SUMCONDITION(
    [Transport].[Detail_Inkooporderregel divers_Inkooporder].[Aantal], 
    [Transport].[Detail_Inkooporderregel divers_Inkooporder].[Detail_Alle reserveringen_Inkooporderregel divers].[Bonregel divers].[Bon]==[Bon] AND
    [Transport].[Detail_Inkooporderregel divers_Inkooporder].[Diversen].[Code]=="T0019"),0.0)


