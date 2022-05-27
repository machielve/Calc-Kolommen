SUMCONDITION(
[Detail_Verkoopregel stuklijst_Order].[Stuklijst].[Detail_Stuklijstregel artikel_Stuklijst].[Totaal gewicht],
[Detail_Verkoopregel stuklijst_Order].[Stuklijst].[Detail_Stuklijstregel artikel_Stuklijst].[Artikel].[Hoofdleverancier].[relatie].[Code]==ConvertIntToString(2002)
AND IsEmpty(
[Detail_Verkoopregel stuklijst_Order].[Stuklijst].[Detail_Stuklijstregel artikel_Stuklijst].[Afwijkende leverancier]))
+SUMCONDITION(
[Detail_Verkoopregel stuklijst_Order].[Stuklijst].[Detail_Stuklijstregel artikel_Stuklijst].[Totaal gewicht],
[Detail_Verkoopregel stuklijst_Order].[Stuklijst].[Detail_Stuklijstregel artikel_Stuklijst].[Afwijkende leverancier].[Code]==ConvertIntToString(2002))
