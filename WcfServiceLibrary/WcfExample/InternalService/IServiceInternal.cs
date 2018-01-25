using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfExample.InternalService
{
    
    [ServiceContract]
    public interface IServiceInternal
    {
        [OperationContract]
        int Multiple(int num1, int num2);
        [OperationContract]
        int Division(int num1, int num2);
    }
}
