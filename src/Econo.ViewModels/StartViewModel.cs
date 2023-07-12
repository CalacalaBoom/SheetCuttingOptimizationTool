using Econo.Datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econo.ViewModels
{
    public class StartViewModel:CommandBase
    {
        public StartModel model { get; set; }=new StartModel();

        public StartViewModel()
        {
            model.testText = "This is a test Text";
        }
    }
}
