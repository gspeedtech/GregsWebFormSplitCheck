using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GregsWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICheckService" in both code and config file together.
    [ServiceContract]
    public interface ICheckService
    {
        [OperationContract]
         GregsChecks GetChecks();
    }
    [DataContract]
    public class GregsChecks
    {
        [DataMember]
        public GregsCommon.Check[] Checks { get; set; }

    }
}
