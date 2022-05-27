If([@Inkoopregels A]==[@Inkoopregels D] AND [@Inkoopregels D]<>"" AND [@Aantal regels]<>0, [@Inkoopregels D], 

If([@Inkoopregels A]<>[@Inkoopregels D] AND [@Inkoopregels A]<>"" AND [@Inkoopregels D]<>"", "Divers", 

If([@Inkoopregels A]<>[@Inkoopregels D] AND [@Inkoopregels A]<>"" AND [@Inkoopregels D]=="", [@Inkoopregels A], 

If([@Inkoopregels A]<>[@Inkoopregels D] AND [@Inkoopregels A]=="" AND [@Inkoopregels D]<>"", [@Inkoopregels D], 

If([@Aantal regels]==0, "Leeg", "Voorraad")))))