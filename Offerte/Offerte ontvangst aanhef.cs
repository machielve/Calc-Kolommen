If([Taal].[Code]=="NL", If([Contactpersoon].[Persoon].[Geslacht]==[$Gender.Man], "Geachte heer", 
                        If([Contactpersoon].[Persoon].[Geslacht]==[$Gender.Vrouw], 
                        "Geachte mevrouw", "Geachte heer / mevrouw")), 
If([Taal].[Code]=="EN", If([Contactpersoon].[Persoon].[Geslacht]==[$Gender.Man], "Dear Mr.", 
                        If([Contactpersoon].[Persoon].[Geslacht]==[$Gender.Vrouw], "Dear Ms.", 
                        "Dear Mr. / Ms.")), 
If([Taal].[Code]=="DE", If([Contactpersoon].[Persoon].[Geslacht]==[$Gender.Man], "Sehr geëhrter Herr", 
                        If([Contactpersoon].[Persoon].[Geslacht]==[$Gender.Vrouw], "Sehr geëhrter Frau", 
                        "Sehr geëhrter Herr / Frau")), 
"toet")))+
If(IsEmpty([Contactpersoon].[Persoon].[Tussenvoegsel]), " ", " "+[Contactpersoon].[Persoon].[Tussenvoegsel]+" ")+[Contactpersoon].[Persoon].[Achternaam]+","