using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_C_.Factory;

namespace Factory.Factory
{
    public class ColpatriaConcrete : ReportManager
    {
        public override IFactory MakeReport()
        {
            return new ColpatriaReport();
        }
    }
}
