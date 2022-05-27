if      (MAX([Detail_Offerteregels stuklijst_Offerte].[BTW-code].[BTW-bedrijfsgroep].[Code])==MIN([Detail_Offerteregels stuklijst_Offerte].[BTW-code].[BTW-bedrijfsgroep].[Code]) AND
        MAX([Detail_Offerteregels stuklijst_Offerte].[BTW-code].[BTW-bedrijfsgroep].[Code])==([BTW-bedrijfsgroep].[Code]) AND
        MIN([Detail_Offerteregels stuklijst_Offerte].[BTW-code].[BTW-bedrijfsgroep].[Code])==([BTW-bedrijfsgroep].[Code]),
        "BTWRegels correct",
        "BTWRegels fout"
)
