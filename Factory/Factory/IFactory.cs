using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Training_C_.Factory
{
    public interface IFactory
    {
        void InsertTotalPrice();
        void InsertHealthInsuranceName();
        void InsertPatientId();
        void InsertOrderId ();
    }

}
