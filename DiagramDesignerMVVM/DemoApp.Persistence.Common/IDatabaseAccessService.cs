using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DemoApp.Persistence.Common
{
    public interface IDatabaseAccessService
    {
        //delete methods
        void DeleteConnection(int connectionId);
        void DeletePersistDesignerItem(int persistDesignerId);
        void DeleteSettingDesignerItem(int settingsDesignerItemId);

        //save methods
        int SaveDiagram(DiagramItem diagram);
        //PersistDesignerItem is pecific to the DemoApp example
        int SavePersistDesignerItem(PersistDesignerItem persistDesignerItemToSave);
        //SettingsDesignerItem is pecific to the DemoApp example
        int SaveSettingDesignerItem(SettingsDesignerItem settingsDesignerItemToSave);
        int SaveUvvDesignerItem(UvvDesignerItem uvvDesignerItemToSave);
        int SaveConnection(Connection connectionToSave);
        int SaveGroupingDesignerItem(GroupDesignerItem groupDesignerItem);

        bool Compare(Diagram diagram);
        //Fetch methods
        IEnumerable<DiagramItem> FetchAllDiagram();
        DiagramItem FetchDiagram(int diagramId);
        //PersistDesignerItem is pecific to the DemoApp example
        PersistDesignerItem FetchPersistDesignerItem(int settingsDesignerItemId);
        //SettingsDesignerItem is pecific to the DemoApp example
        SettingsDesignerItem FetchSettingsDesignerItem(int settingsDesignerItemId);
        UvvDesignerItem FetchUvvDesignerItem(int uvvDesignerItemId);
        Connection FetchConnection(int connectionId);
        GroupDesignerItem FetchGroupingDesignerItem(int itemId);
    }
}
