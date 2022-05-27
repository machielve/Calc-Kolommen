SUMCONDITION(
[Detail_Verkoopregel stuklijst_Order].[Stuklijst].[Detail_Stuklijstregel artikel_Stuklijst].[Totaal gewicht],
[Detail_Verkoopregel stuklijst_Order].[Stuklijst].[Detail_Stuklijstregel artikel_Stuklijst].[Artikel].[Hoofdleverancier].[relatie].[Code]==ConvertIntToString(18002)
AND IsEmpty(
[Detail_Verkoopregel stuklijst_Order].[Stuklijst].[Detail_Stuklijstregel artikel_Stuklijst].[Afwijkende leverancier])
AND
[Detail_Verkoopregel stuklijst_Order].[Stuklijst].[Detail_Stuklijstregel artikel_Stuklijst].[Artikel].[Artikelgroep].[Code]==ConvertIntToString(3000))
+SUMCONDITION(
[Detail_Verkoopregel stuklijst_Order].[Stuklijst].[Detail_Stuklijstregel artikel_Stuklijst].[Totaal gewicht],
[Detail_Verkoopregel stuklijst_Order].[Stuklijst].[Detail_Stuklijstregel artikel_Stuklijst].[Afwijkende leverancier].[Code]==ConvertIntToString(18002)
AND
[Detail_Verkoopregel stuklijst_Order].[Stuklijst].[Detail_Stuklijstregel artikel_Stuklijst].[Artikel].[Artikelgroep].[Code]==ConvertIntToString(3000))
