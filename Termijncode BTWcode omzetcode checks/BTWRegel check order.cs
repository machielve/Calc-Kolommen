if (    MAX([Detail_Verkoopregel stuklijst_Order].[BTW-code].[BTW-bedrijfsgroep].[Code])==MIN([Detail_Verkoopregel stuklijst_Order].[BTW-code].[BTW-bedrijfsgroep].[Code]) AND
        MAX([Detail_Verkoopregel stuklijst_Order].[BTW-code].[BTW-bedrijfsgroep].[Code])==([BTW-bedrijfsgroep].[Code]) AND
        MIN([Detail_Verkoopregel stuklijst_Order].[BTW-code].[BTW-bedrijfsgroep].[Code])==([BTW-bedrijfsgroep].[Code]),
        "BTWRegels correct",
        "BTWRegels fout"
)
