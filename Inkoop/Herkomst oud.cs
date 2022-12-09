If([@Inkoopregels A]==[@Inkoopregels D] AND [@Inkoopregels D]<>"" AND [@Aantal regels besteld]<>0, 

[@Inkoopregels D], 

If([@Inkoopregels A]<>[@Inkoopregels D] AND [@Inkoopregels A]<>"" AND [@Inkoopregels D]<>"", 

"Combi", 

If([@Inkoopregels A]<>[@Inkoopregels D] AND [@Inkoopregels A]<>"" AND [@Inkoopregels D]=="", 

[@Inkoopregels A], If([@Inkoopregels A]<>[@Inkoopregels D] AND [@Inkoopregels A]=="" AND [@Inkoopregels D]<>"", [@Inkoopregels D], If([@Aantal regels besteld]==0, "Leeg", "Voorraad")))))