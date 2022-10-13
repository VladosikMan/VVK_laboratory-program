using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Questions
{
    internal interface ISharedScoped
    {
        public void SetSharedScope(SharedScope sharedScope);
    }
}
