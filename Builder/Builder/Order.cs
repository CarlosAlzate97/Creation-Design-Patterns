using System.Reflection.Metadata.Ecma335;

namespace Training_C_.Builder;
public class Order
{
    public string Patient { get; set; }
    public string HealthPlan { get; set; }
    public string Doctor { get; set; }
    public List<string> Exams { get; set; }
    public int OrderId { get; set; }

    public Order(int orderId,string healthPlan,string patient,string doctor, List<string> examsList)
    {
        Patient = patient;
        HealthPlan = healthPlan;
        Doctor = doctor;
        Exams = examsList;
        OrderId = orderId;
    }

    public void Display()
    {
        Console.WriteLine($"Numero de orden: {OrderId}");
        Console.WriteLine($"Aseguradora: {HealthPlan}");
        Console.WriteLine($"Paciente: {Patient}");
        Console.WriteLine($"Doctor: {Doctor}");
        foreach (var exam in Exams) 
        {
            Console.WriteLine($"--- {exam }");
        }

    }

}