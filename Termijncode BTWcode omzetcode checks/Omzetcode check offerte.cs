If(     ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="NL"    AND [Omzetcode].[Code]=="NL")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="AE"    AND [Omzetcode].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="AW"    AND [Omzetcode].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="NO"    AND [Omzetcode].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="UA"    AND [Omzetcode].[Code]=="BEU")    
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="GB"    AND [Omzetcode].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="US"    AND [Omzetcode].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="TR"    AND [Omzetcode].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]=="IL"    AND [Omzetcode].[Code]=="BEU")
    
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]<>"NL" 
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"AE"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"GB"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"AW"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"NO"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"UA"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"TR"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"IL"
                                  AND [Bestemmingsadres].[Adres].[Land].[Code]<>"US"    AND [Omzetcode].[Code]<>"NL"
                                                                                        AND [Omzetcode].[Code]<>"BEU")
                                  
    OR  ([Incoterm].[Code]=="DAP" AND [Bestemmingsadres].[Adres].[Land].[Code]<>"NL"    AND [Relatie].[Bezoekadres].[Land].[Code]=="NL" AND [Omzetcode].[Code]=="NL")
    OR  ([Incoterm].[Code]=="DAP" AND Left([Bestemmingsadres].[Naam],9)=="Foldy Pac"    AND [Omzetcode].[Code]=="BEU")


    
    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="NL"       AND [Omzetcode].[Code]=="NL")
    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="UA"       AND [Omzetcode].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="AE"       AND [Omzetcode].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="AW"       AND [Omzetcode].[Code]=="BEU")    
    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="GB"       AND [Omzetcode].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="NO"       AND [Omzetcode].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="US"       AND [Omzetcode].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]=="TR"       AND [Omzetcode].[Code]=="BEU")

    OR  ([Incoterm].[Code]=="FCA" AND [Relatie].[Bezoekadres].[Land].[Code]<>"NL"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"AE"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"AW"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"UA"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"GB"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"NO"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"UA"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"TR"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"US"       AND [Omzetcode].[Code]<>"NL"
                                                                                        AND [Omzetcode].[Code]<>"BEU")
        
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="NL"       AND [Omzetcode].[Code]=="NL")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="AE"       AND [Omzetcode].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="AW"       AND [Omzetcode].[Code]=="BEU")    
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="GB"       AND [Omzetcode].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="NO"       AND [Omzetcode].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="US"       AND [Omzetcode].[Code]=="BEU")
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]=="TR"       AND [Omzetcode].[Code]=="BEU")
    
    OR  ([Incoterm].[Code]=="EXW" AND [Relatie].[Bezoekadres].[Land].[Code]<>"NL"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"AE"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"AW"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"GB"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"NO"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"UA"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"TR"
                                  AND [Relatie].[Bezoekadres].[Land].[Code]<>"US"       AND [Omzetcode].[Code]<>"NL"
                                                                                        AND [Omzetcode].[Code]<>"BEU")
                                                                                                                        ,"Omzetcode correct", "Omzetcode fout")