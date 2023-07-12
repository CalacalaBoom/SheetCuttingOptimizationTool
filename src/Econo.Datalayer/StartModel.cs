using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econo.Datalayer
{
    public class StartModel:NotifyBase
    {
        private string _testText;
        public string testText
        {
            get { return _testText; }
            set { _testText = value; this.DoNotify(); }
        }
    }
}
