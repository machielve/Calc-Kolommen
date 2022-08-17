If(
IsEmpty([Artikel OHW-regel].[Inkoopontvangstregel artikel].[Inkooporderregel artikel].[Inkooporder].[Inkoopordernummer]) AND
IsEmpty([OHW-regel divers].[Ontvangstregel divers].[Inkooporderregel diversen].[Inkooporder].[Inkoopordernummer]),
[Uitbesteed werk OHW-regel].[Goederenontvangstregel uitbesteed].[Inkooporderregel uitbesteed werk].[Inkooporder].[Inkoopordernummer],
0)+

If(
IsEmpty([Uitbesteed werk OHW-regel].[Goederenontvangstregel uitbesteed].[Inkooporderregel uitbesteed werk].[Inkooporder].[Inkoopordernummer]) AND
IsEmpty([OHW-regel divers].[Ontvangstregel divers].[Inkooporderregel diversen].[Inkooporder].[Inkoopordernummer]),
[Artikel OHW-regel].[Inkoopontvangstregel artikel].[Inkooporderregel artikel].[Inkooporder].[Inkoopordernummer],
0)+

If(
IsEmpty([Artikel OHW-regel].[Inkoopontvangstregel artikel].[Inkooporderregel artikel].[Inkooporder].[Inkoopordernummer]) AND
IsEmpty([Uitbesteed werk OHW-regel].[Goederenontvangstregel uitbesteed].[Inkooporderregel uitbesteed werk].[Inkooporder].[Inkoopordernummer]),
[OHW-regel divers].[Ontvangstregel divers].[Inkooporderregel diversen].[Inkooporder].[Inkoopordernummer],
0)