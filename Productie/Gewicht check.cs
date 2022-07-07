If([@Vrachtbrief gewicht]>24000.0, "Meer dan 1 transport nodig", 
    If([@Vrachtbrief gewicht]==0.0 AND [@Aantal pakbonnen]<>0, "Pakbon is leeg", ""))