namespace Training_C_.Factory
{
    public class SuraReport : IFactory
    {
        public void InsertHealthInsuranceName()
        {
            Console.WriteLine("\n Reporte de: Sura");
        }

        public void InsertOrderId()
        {
            Console.WriteLine("\n Orden numero: 2154487 ");
        }

        public void InsertPatientId()
        {
            Console.WriteLine("\n Identificacion del paciente:  cc 284781851");
        }

        public void InsertTotalPrice()
        {
            Console.WriteLine("\n Precio total $54874151");
        }
    }
}