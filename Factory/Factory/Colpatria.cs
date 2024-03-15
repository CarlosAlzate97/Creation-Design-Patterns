namespace Training_C_.Factory
{
    public class Colpatria : IFactory
    {
        public void InsertHealthInsuranceName()
        {
            Console.WriteLine("\n Reporte de: Colpatria");
        }

        public void InsertOrderId()
        {
            Console.WriteLine("\n Orden numero: 215457 ");
        }

        public void InsertPatientId()
        {
            Console.WriteLine("\n Identificacion del paciente:  cc 10234554");
        }

        public void InsertTotalPrice()
        {
            Console.WriteLine("\n Precio total $12514545");
        }
    }
}