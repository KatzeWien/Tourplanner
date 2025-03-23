using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersionOfTourplanner.ViewModel
{
    public class VMTourWindow
    {
        public AllDataManagement DataManagement { get; }
        public VMTourWindow(AllDataManagement dataManagement)
        {
            DataManagement = dataManagement;
        }
    }
}
