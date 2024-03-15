using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_C_.Factory;

namespace Factory.Factory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ReportManager reportManager;
            Console.WriteLine("Ingrese el tipo de reporte que necesita");

            string? typeOfReport = Console.ReadLine();

            if (typeOfReport.ToLower() == "sura")
            {
                reportManager = new SuraConcrete();
            }
            else //if (typeOfReport.ToLower() == "colpatria")
            {
                reportManager = new ColpatriaConcrete();
            }
            reportManager.MakeReport();
            reportManager.reportManager();
        }
    }
}
