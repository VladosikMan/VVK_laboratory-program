using System.Collections.Generic;

namespace DemoApp.Persistence.Common
{
	public class Diagram
	{
		public DiagramItem DiagramItem { get; set; }

		public List<Connection> Connections { get; set; }

		public List<PersistDesignerItem> PersistDesignerItem { get; set; }

		public List<SettingsDesignerItem> SettingsDesignerItem { get; set; }

		public List<GroupDesignerItem> GroupDesignerItem { get; set; }

		public List<UvvDesignerItem> UvvDesignerItem { get; set; }

		public Diagram()
		{
			DiagramItem = new DiagramItem();
			Connections = new List<Connection>();
			PersistDesignerItem = new List<PersistDesignerItem>();
			SettingsDesignerItem = new List<SettingsDesignerItem>();
			GroupDesignerItem = new List<GroupDesignerItem>();
			UvvDesignerItem = new List<UvvDesignerItem>();
		}

		public override bool Equals(object obj)
		{
			var diagram = obj as Diagram;

			if (diagram == null)
			{
				return false;
			}

			if (diagram.DiagramItem.DesignerItems.Count != DiagramItem.DesignerItems.Count)
			{
				return false;
			}

			if (diagram.Connections.Count != Connections.Count)
			{
				return false;
			}

			foreach (var diagramItem in diagram.DiagramItem.DesignerItems)
			{
				var result = DiagramItem.DesignerItems.Exists(x => x.ItemType == diagramItem.ItemType);

				if (!result)
				{
					return false;
				}
			}

			foreach (var connection in diagram.Connections)
			{
				var result = Connections.Exists(x => x.SourceType == connection.SourceType) && 
				             Connections.Exists(x => x.SinkType == connection.SinkType);

				if (!result)
				{
					return false;
				}
			}

			return true;
		}
	}
}