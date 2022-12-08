If([@Productieregels]==0, "Geen productie", "Lopende productie")










// hieronder de scripting opmaak regel


using Ridder.Client.UIScript;
using System.Drawing;
using Ridder.Common.Script;
using System;

public class RidderScript : ConditionalFormatScript
{
	public void Execute()

	{
		DateTime now = DateTime.Today;

		if (this.Item.Value.ToString() == "Geen productie")
		{
			this.Item.Control.SetBackgroundColor(Color.Orange);
		}


		else if (this.Item.Value.ToString() == "Lopende productie" && FindItem("VZD").Value.ToDateTime().Date >= now)
		{
			this.Item.Control.SetBackgroundColor(Color.Yellow);
		}

		else if (this.Item.Value.ToString() == "Lopende productie" && FindItem("VZD").Value.ToDateTime().Date < now)
		{
			this.Item.Control.SetBackgroundColor(Color.Red);
		}
	}
}