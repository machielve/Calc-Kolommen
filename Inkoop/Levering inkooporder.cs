If([Incoterm].[Code]=="DAP" AND [Los adres]==1098, "Levering Almacon", "")
+If([Incoterm].[Code]=="DAP" AND [Los adres]<>1098 AND [Los adres].[Relatie].[Bedrijfstak].[Code]=="COATER", "Levering coater", 
        If([Incoterm].[Code]=="DAP" AND [Los adres]<>1098 , "Levering on site", ""))
+If([Incoterm].[Code]<>"DAP", "Af halen", "")