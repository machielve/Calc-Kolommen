If(
Right(
    Replace(
        Replace(
            Replace(
                Replace( 
                    [Directe telefoon],
                "(0)",""), 
            " " ,""),
        "+","00"),
    "-","")
,5)
==
Right(
    Replace(
        Replace(
            Replace(
                Replace( 
                    [Relatie].[Telefoonnummer],
                "(0)",""), 
            " " ,""),
        "+","00"),
    "-","")
,5)
AND
[Directe telefoon]<>""

,"Gelijk Nummer","")