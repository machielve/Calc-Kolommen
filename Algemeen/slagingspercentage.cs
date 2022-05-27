(COUNTCONDITION( [Detail_Verkoopoffertes_Relatie].[Workflowstatus].[Status], [Detail_Verkoopoffertes_Relatie].[Workflowstatus].[Status]=="Order" ))/
(
(COUNTCONDITION( [Detail_Verkoopoffertes_Relatie].[Workflowstatus].[Status], [Detail_Verkoopoffertes_Relatie].[Workflowstatus].[Status]=="Order" ))+
(COUNTCONDITION( [Detail_Verkoopoffertes_Relatie].[Workflowstatus].[Status], [Detail_Verkoopoffertes_Relatie].[Workflowstatus].[Status]=="Submitted" ))+
(COUNTCONDITION( [Detail_Verkoopoffertes_Relatie].[Workflowstatus].[Status], [Detail_Verkoopoffertes_Relatie].[Workflowstatus].[Status]=="Rejected" ))
)