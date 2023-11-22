If([@Bestel regels]+[@Pickafwijking]==0, "Geen inkoop", 
If([@Bestel regels]+[@Pickafwijking]==[@Ontvangstregels], "Inkoop ontvangen", "Wacht op inkoop"))

