using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_C_.Builder
{
    public class Director
    {
        public object OrderWithoutMedician(IOrder builder)
        {
            builder.AddPatient("Nombre paciente genérico");
            builder.AddDoctor("Orden sin médico");
            builder.AddHealthPlan("sura");
            builder.AddExams(new List<string> { "Hemograma, Creatinina" });
            builder.AddOrderId(1);
            return builder.GetOrder();
        }
        public object OrderWithtMedician(IOrder builder)
        {
            builder.AddPatient("Nombre paciente genérico");
            builder.AddDoctor("Orden con médico");
            builder.AddHealthPlan("Colpatira");
            builder.AddExams(new List<string> { "Testosterona en suero, Citoquímico de orina" });
            builder.AddOrderId(1);
            return builder.GetOrder();
        }
    }
}