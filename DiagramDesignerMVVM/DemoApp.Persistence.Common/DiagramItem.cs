using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoApp.Persistence.Common
{
    public class DiagramItem : PersistableItemBase, IDiagramItem
    {
        public DiagramItem() 
        {
	        this.DesignerItems = new List<DiagramItemData>();
	        this.ConnectionIds = new List<int>();
        }

        public List<DiagramItemData> DesignerItems { get; set; }
        public List<int> ConnectionIds { get; set; }
    }


    public class DiagramItemData
    {
	    private static int count = 0;

        public DiagramItemData(int itemId, Type itemType)
        {
	        count++;
            this.ItemId = itemId;
            this.ItemType = itemType;
        }

        public int ItemId { get; set; }
        public Type ItemType { get; set; }
    }  
}
