If(     ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="NL" AND [BTW-bedrijfsgroep].[Code]=="NL")

    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="AE" AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="AW" AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="NO" AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="UA" AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="US" AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]<>"NL"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"AE"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"AW"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"NO"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"UA"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"US" AND [BTW-bedrijfsgroep].[Code]<>"NL")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]<>"NL" AND [Relatie].[Bezoekadres].[Land].[Code]=="NL" AND [BTW-bedrijfsgroep].[Code]=="NL")
    OR  ([Incoterm].[Code]=="DAP" AND Left([Bestemmingsadres].[Naam],9)=="Foldy Pac" AND [BTW-bedrijfsgroep].[Code]=="BEU")
    
    
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="NL" AND [BTW-bedrijfsgroep].[Code]=="NL")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="AE" AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="AW" AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="NO" AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="UA" AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="US" AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]<>"NL" 
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"AE"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"AW"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"NO"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"UA"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"US" AND [BTW-bedrijfsgroep].[Code]<>"NL")
                                                                                                                        , "BTWcode correct", "BTWcode fout")