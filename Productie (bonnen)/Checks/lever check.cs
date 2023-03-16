If(IsEmpty([Project locatie]), "Geen project locatie", 

If([Project locatie]<>[Order].[Bestemmingsadres] AND [Order].[Bestemmingsadres]<>1098, "Lever adres fout", ""))