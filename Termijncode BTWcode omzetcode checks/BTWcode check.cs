If(     ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="NL"    AND [BTW-bedrijfsgroep].[Code]=="NL")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="AE"    AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="AU"    AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="AW"    AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="CA"    AND [BTW-bedrijfsgroep].[Code]=="BEU")    
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="CH"    AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="GB"    AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="IL"    AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="NO"    AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="TR"    AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="UA"    AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="US"    AND [BTW-bedrijfsgroep].[Code]=="BEU")    
    
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]<>"NL"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"AE"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"AU"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"AW"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"CH"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"GB"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"IL"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"NO"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"TR"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"UA"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"US"    AND [BTW-bedrijfsgroep].[Code]<>"NL"
                                                                                        AND [BTW-bedrijfsgroep].[Code]<>"BEU"
                                                                                        AND [Relatie].[Bezoekadres].[Land].[Code]<>"NL")
                                  
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]<>"NL"    AND [Relatie].[Bezoekadres].[Land].[Code]=="NL" AND [BTW-bedrijfsgroep].[Code]=="NL")
    OR  ([Incoterm].[Code]=="DAP" AND Left([Bestemmingsadres].[Naam],9)=="Foldy Pac"    AND [BTW-bedrijfsgroep].[Code]=="BEU")





    



    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="NL"       AND [BTW-bedrijfsgroep].[Code]=="NL")
    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="AE"       AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="AW"       AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="CA"       AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="CH"       AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="GB"       AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="IL"       AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="NO"       AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="TR"       AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="UA"       AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="US"       AND [BTW-bedrijfsgroep].[Code]=="BEU")

    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]<>"NL" 
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"AE"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"AW"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"CA"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"CH"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"GB"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"IL"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"NO"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"TR"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"UA"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"US"       AND [BTW-bedrijfsgroep].[Code]<>"NL"
                                                                                        AND [BTW-bedrijfsgroep].[Code]<>"BEU"
                                                                                        AND [Relatie].[Bezoekadres].[Land].[Code]<>"NL")

    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="NL"       AND [BTW-bedrijfsgroep].[Code]=="NL")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="AE"       AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="AW"       AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="CH"       AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="GB"       AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="IL"       AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="NO"       AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="TR"       AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="UA"       AND [BTW-bedrijfsgroep].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="US"       AND [BTW-bedrijfsgroep].[Code]=="BEU")
    
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]<>"NL" 
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"AE"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"AW"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"CH"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"GB"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"IL"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"NO"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"TR"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"UA"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"US"       AND [BTW-bedrijfsgroep].[Code]<>"NL"
                                                                                        AND [BTW-bedrijfsgroep].[Code]<>"BEU")
                                                                                                                        , "BTWcode correct", "BTWcode fout")