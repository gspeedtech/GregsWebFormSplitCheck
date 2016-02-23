using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using GregsCommon;

namespace GregsWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CheckService" in both code and config file together.
    public class CheckService : ICheckService
    {
        public static List<CheckItem> CheckItems = new List<CheckItem>();
        public static GregsChecks GetChecks(Check Check)
        {
            //GregsCommon.Check  Checks = new GregsCommon.Check();
           
            CheckItems  = GregsCommon.Check.GetCheckItems(Check).ToArray();
        }
    }
}
