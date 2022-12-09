If(COUNTCONDITION([Detail_Bonregel artikel_Bon].[bonregel id], 
[Detail_Bonregel artikel_Bon].[Artikel].[Detail_Artikelen per leverancier_Artikel].[Relatie]==[Detail_Bonregel artikel_Bon].[Leverancier] AND 
[Detail_Bonregel artikel_Bon].[Artikel].[Detail_Artikelen per leverancier_Artikel].[Artikel type]=="2")-
COUNT([Detail_Bonregel artikel_Bon].[Detail_Bonregel artikel uitbesteed werk_KMB bonregel artikel].[Bonregel artikel uitbesteed werk id])>0, "Niet alle regels een coating", "")