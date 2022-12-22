If([Taal].[Code]=="NL", 
    If(IsEmpty([Contactpersoon].[Persoon].[Achternaam]),                "Geachte relatie",
    If([Contactpersoon].[Persoon].[Geslacht]==[$Gender.Man],            "Geachte heer", 
    If([Contactpersoon].[Persoon].[Geslacht]==[$Gender.Vrouw],          "Geachte mevrouw", 
                                                                        "Geachte heer / mevrouw"))), 
If([Taal].[Code]=="EN",
    If(IsEmpty([Contactpersoon].[Persoon].[Achternaam]),                "Dear relation",
    If([Contactpersoon].[Persoon].[Geslacht]==[$Gender.Man],            "Dear Mr.", 
    If([Contactpersoon].[Persoon].[Geslacht]==[$Gender.Vrouw],          "Dear Ms.", 
                                                                        "Dear Mr. / Ms."))), 
If([Taal].[Code]=="DE", 
    If(IsEmpty([Contactpersoon].[Persoon].[Achternaam]),                "Sehr geehrte Damen und Herren",
    If([Contactpersoon].[Persoon].[Geslacht]==[$Gender.Man],            "Sehr geëhrter Herr", 
    If([Contactpersoon].[Persoon].[Geslacht]==[$Gender.Vrouw],          "Sehr geëhrter Frau", 
                                                                        "Sehr geëhrter Herr / Frau"))), 
                                                                        "FOUT")))
                                                                        
                                                                        +

If(IsEmpty([Contactpersoon].[Persoon].[Tussenvoegsel]),                 " ", 
                                                                        " " + [Contactpersoon].[Persoon].[Tussenvoegsel]+ " ") 
                                                                        
                                                                        + [Contactpersoon].[Persoon].[Achternaam]
                                                                        + ","