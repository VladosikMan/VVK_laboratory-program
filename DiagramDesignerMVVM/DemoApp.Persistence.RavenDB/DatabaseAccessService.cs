using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Raven.Client.Embedded;
using Raven.Client;
using DemoApp.Persistence.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DemoApp.Persistence.RavenDB
{
	/// <summary>
	/// I decided to use RavenDB instead of SQL, to save people having to have SQL Server, and also
	/// it just takes less time to do with Raven. This is ALL the CRUD code. Simple no?
	/// 
	/// Thing is the IDatabaseAccessService and the items it persists could easily be applied to helper methods that
	/// use StoredProcedures or ADO code, the data being stored would be exactly the same. You would just need to store
	/// the individual property values in tables rather than store objects.
	/// </summary>
	public class DatabaseAccessService : IDatabaseAccessService
	{
		public bool Compare(Diagram diagram)
		{
			return diagram.Equals(JsonConvert.DeserializeObject<Diagram>(File.ReadAllText("123.json")));
		}

		public Diagram DiagramToSave = new Diagram();

		public void DeleteConnection(int connectionId)
		{
			
		}

		public void DeletePersistDesignerItem(int persistDesignerId)
		{
			
		}

		public void DeleteSettingDesignerItem(int settingsDesignerItemId)
		{
			
		}

		public int SaveDiagram(DiagramItem diagram)
		{
			DiagramToSave.DiagramItem = diagram;
			JsonSerializer serializer = new JsonSerializer();
			serializer.Converters.Add(new JavaScriptDateTimeConverter());
			serializer.NullValueHandling = NullValueHandling.Ignore;

			using (StreamWriter sw = new StreamWriter("123.json"))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				serializer.Serialize(writer, DiagramToSave);
			}
			
			return diagram.Id;
		}

		public int SavePersistDesignerItem(PersistDesignerItem persistDesignerItemToSave)
		{
			DiagramToSave.PersistDesignerItem.Add(persistDesignerItemToSave);

			return persistDesignerItemToSave.Id;
		}

		public int SaveSettingDesignerItem(SettingsDesignerItem settingsDesignerItemToSave)
		{
			DiagramToSave.SettingsDesignerItem.Add(settingsDesignerItemToSave);

			return settingsDesignerItemToSave.Id;
		}

		public int SaveConnection(Connection connectionToSave)
		{
			DiagramToSave.Connections.Add(connectionToSave);

			return connectionToSave.Id;
		}

		public int SaveGroupingDesignerItem(GroupDesignerItem groupDesignerItem)
		{
			DiagramToSave.GroupDesignerItem.Add(groupDesignerItem);

			return groupDesignerItem.Id;
		}

		public IEnumerable<DiagramItem> FetchAllDiagram()
		{
			var list = new List<DiagramItem>();
			return list;
		}

		public DiagramItem FetchDiagram(int diagramId)
		{
			DiagramToSave = new Diagram();
			DiagramToSave.DiagramItem.ResetCount();
			DiagramToSave = JsonConvert.DeserializeObject<Diagram>(File.ReadAllText("123.json"));
			return DiagramToSave.DiagramItem;
		}

		public PersistDesignerItem FetchPersistDesignerItem(int settingsDesignerItemId)
		{
			return DiagramToSave.PersistDesignerItem.Find(x => x.Id.Equals(settingsDesignerItemId));
		}

		public SettingsDesignerItem FetchSettingsDesignerItem(int settingsDesignerItemId)
		{
			return DiagramToSave.SettingsDesignerItem.Find(x => x.Id.Equals(settingsDesignerItemId));
		}

		public Connection FetchConnection(int connectionId)
		{
			return DiagramToSave.Connections.Find(x => x.Id.Equals(connectionId));
		}

		public GroupDesignerItem FetchGroupingDesignerItem(int itemId)
		{
			return DiagramToSave.GroupDesignerItem.Find(x => x.Id.Equals(itemId));
		}
	}
}
