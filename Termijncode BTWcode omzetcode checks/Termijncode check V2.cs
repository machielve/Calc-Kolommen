If(    (SubString( [Termijncode].[Code],1,2)=="P_"),"Project termijncode",

if([@Total net amount]>=[@min termijnbedrag] AND
    [@Total net amount]<[@max termijn bedrag],"Termijncode correct","Termijncode fout"))