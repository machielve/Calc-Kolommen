if  (   MAX([Detail_Verkoopregel stuklijst_Order].[Omzetcode].[Code])==MIN([Detail_Verkoopregel stuklijst_Order].[Omzetcode].[Code]) AND   
        MAX([Detail_Verkoopregel stuklijst_Order].[Omzetcode].[Code])==([Omzetcode].[Code]) AND 
        MIN([Detail_Verkoopregel stuklijst_Order].[Omzetcode].[Code])==([Omzetcode].[Code]),
        "OmzetRegels correct",
        "OmzetRegels fout"
)
