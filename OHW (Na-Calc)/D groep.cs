If(Left([Code], 1) == "T", "Transport", "") + 
If(Left([Code], 1) == "T" AND [OHW-regel divers].[Ontvangstregel divers].[Inkooporderregel diversen].[Inkooporder].[Los adres]<>[Order].[Bestemmingsadres], " Intern","")+

If(Left([Code], 1) == "A", "Algemeen", "") +
If(Left([Code], 1) == "B", "Bewerkingen", "") +

If(Left([Code], 3) == "D10", "Kolommen", "") +
If(Left([Code], 3) == "D15", "Schoring", "") +
If(Left([Code], 3) == "D20", "Koud gewalste liggers", "") +
If(Left([Code], 3) == "D25", "Warm gewalste liggers", "") +
If(Left([Code], 3) == "D30", "Vloerdelen hout", "") +
If(Left([Code], 3) == "D35", "Vloerdelen staal", "") +
If(Left([Code], 3) == "D40", "Trappen", "") +
If(Left([Code], 3) == "D50", "Leuning", "") +
If(Left([Code], 3) == "D51", "Hekwerk", "") +
If(Left([Code], 3) == "D55", "Pallet opzet plaatsen", "") +
If(Left([Code], 3) == "D60", "Accessoires constructie", "") +
If(Left([Code], 3) == "D70", "Bevestigingsmaterialen", "") +
If(Left([Code], 3) == "D75", "Accessoires", "") +
If(Left([Code], 3) == "D80", "Montage", "") +
If(Left([Code], 3) == "D85", "Bewerkingen", "") +
If(Left([Code], 2) == "D9", "Rest", "") +

If(Left([Code], 4) == "K001", "Warm gewalste liggers", "") +
If(Left([Code], 4) == "K002", "Kolommen", "") +
If(Left([Code], 4) == "K003", "Kolommen", "") +

If(Left([Code], 4) == "M001", "Koud gewalste liggers", "") +
If(Left([Code], 4) == "M003", "Vloerdelen hout", "") +
If(Left([Code], 4) == "M004"  , "Vloerdelen Staal", "")+

If(Left([Code], 3) == "U10", "Coaten", "")
