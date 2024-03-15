using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_C_.Factory
{
    public abstract class ReportManager
    {
        public abstract IReport MakeReport();

        public void reportManager()
        {
            IReport report = this.MakeReport();
            report.InsertPatientId();
            report.InsertHealthInsuranceName();
            report.InsertOrderId();
            report.InsertTotalPrice();

        }
    }
}

