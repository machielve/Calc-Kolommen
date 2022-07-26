MAXCONDITION(
[Detail_Documenten van order_Order].[Datum aangemaakt],
[Detail_Documenten van order_Order].[Document].[Omschrijving]==
CONVERTINTTOSTRING([Detail_Documenten van order_Order].[Order].[Ordernummer])+"_ce-markering")