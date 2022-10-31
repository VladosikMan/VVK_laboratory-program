using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using DiagramDesigner.Helpers;
using DiagramDesigner;

namespace DemoApp
{
    public class ToolBoxViewModel
    {
        private List<ToolBoxData> toolBoxItems = new List<ToolBoxData>();

        public ToolBoxViewModel()
        {
            toolBoxItems.Add(new ToolBoxData("../Images/Processor.png", typeof(SettingsDesignerItemViewModel)));
            toolBoxItems.Add(new ToolBoxData("../Images/Memory.png", typeof(PersistDesignerItemViewModel)));
            toolBoxItems.Add(new ToolBoxData("../Images/UVV.png", typeof(UvvDesignerItemViewModel)));
        }

        public List<ToolBoxData> ToolBoxItems
        {
            get { return toolBoxItems; }
        }
    }
}
