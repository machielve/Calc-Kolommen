If(IsEmpty([Project locatie]), "Er is geen project locatie geselecteerd", 

If([Project locatie]<>[Order].[Bestemmingsadres] AND [Order].[Bestemmingsadres]<>1098, "Project locatie is afwijkend van adres op de order", ""))