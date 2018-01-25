using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfExample.InternalService
{
  
    public class ServiceInternal : IServiceInternal
    {
        public int Division(int num1, int num2)
        {
           
           if (num2 != 0)
            {
                 return num1 / num2;
            }
            else
            {
                return 0;
            }
        }

        public int Multiple(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
