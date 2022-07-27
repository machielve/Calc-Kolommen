SUMCONDITION(

[Detail_Verkoopfactuurregel termijn_Verkoopfactuur].[Order].[Detail_Bonregel artikel_Order].[Totaal gewicht], 
LEFT(
[Detail_Verkoopfactuurregel termijn_Verkoopfactuur].[Order].[Detail_Bonregel artikel_Order].[Memo],9)<>"Cancelled")