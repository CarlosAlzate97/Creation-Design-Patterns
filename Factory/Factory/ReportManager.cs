using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_C_.Factory
{
    public abstract class ReportManager
    {
        public abstract IFactory MakeReport();

        public void reportManager()
        {
            IFactory report = this.MakeReport();
            report.InsertPatientId();
            report.InsertHealthInsuranceName();
            report.InsertOrderId();
            report.InsertTotalPrice();

        }
    }
}

