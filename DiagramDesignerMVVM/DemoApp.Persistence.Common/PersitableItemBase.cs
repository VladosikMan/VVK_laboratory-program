using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoApp.Persistence.Common
{
    public abstract class PersistableItemBase
    {
	    public static int count = 0;

        public PersistableItemBase()
        {
	        
        }

        public PersistableItemBase(int id)
        {
            this.Id = id;
            count++;
        }

        public int Id { get; set; }

        public void ResetCount()
        {
	        count = 0;
        }
    }
}
