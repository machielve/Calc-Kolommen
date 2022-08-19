SUM([Herstelorder].[Detail_OHW artikelcorrecties_Order].[Kostprijs correctie])+
SUM([Herstelorder].[Detail_OHW artikelen_Order].[Totaal kostprijs])+
SUM([Herstelorder].[Detail_OHW diversen_Order].[Totaal kostprijs])+
SUM([Herstelorder].[Detail_OHW diversencorrecties_Order].[Kostprijs correctie])+
SUM([Herstelorder].[Detail_OHW uitbesteed werk_Order].[Totaal kostprijs])+
SUM([Herstelorder].[Detail_OHW uitbesteed-werk-correcties_Order].[Kostprijs correctie])+


SUM([Herstelbon].[Detail_OHW artikelcorrecties_Bon].[Kostprijs correctie])+
SUM([Herstelbon].[Detail_OHW artikelen_Bon].[Totaal kostprijs])+
SUM([Herstelbon].[Detail_OHW diversen_Bon].[Totaal kostprijs])+
SUM([Herstelbon].[Detail_OHW diversencorrecties_Bon].[Kostprijs correctie])+
SUM([Herstelbon].[Detail_OHW uitbesteed werk_Bon].[Totaal kostprijs])+
SUM([Herstelbon].[Detail_OHW uitbesteed-werk-correcties_Bon].[Kostprijs correctie])+


SUM([Herstel inkooporder].[Detail_Inkooporderregel artikel_Inkooporder].[Detail_Inkoopfactuurregel artikel_Inkooporderregel artikel].[Netto inkoopprijs])+
SUM([Herstel inkooporder].[Detail_Inkooporderregel divers_Inkooporder].[Detail_Inkoopfactuurregel divers_Inkooporderregel divers].[Netto inkoopprijs])+
SUM([Herstel inkooporder].[Detail_Inkooporderregel uitbesteed werk_Inkooporder].[Detail_Inkoopfactuur uitbesteed werk_Inkooporderregel uitbesteed werk].[Netto inkoopprijs])