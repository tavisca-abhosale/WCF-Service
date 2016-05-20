using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFUserService.DataContract;

namespace WCFUserService
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        User GetUser(long value);

    }

 
}
