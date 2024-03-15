namespace Training_C_.Builder;

public class OrderConcreteBuilder : IOrder
{
    public string Patient { get; set; }
    public string HealthPlan { get; set; }
    public string Doctor { get; set; }
    public List<string> Exams { get; set; }
    public int OrderId { get; set; }

    public string AddDoctor(string doctor)
    {
        this.Doctor = doctor;
        return doctor;
    }

    public List<string> AddExams(List<string> examsList)
    {
        this.Exams = examsList;
        return examsList;
    }

    public string AddHealthPlan(string healthPlan)
    {
        this.HealthPlan = healthPlan;
        return healthPlan;
    }

    public int AddOrderId(int orderId)
    {
        this.OrderId = orderId;
        return orderId;
    }

    public string AddPatient(string patient)
    {
        this.Patient = patient;
        return patient;
    }

    public object GetOrder()
    {
        var order = new Order(OrderId, HealthPlan, Patient, Doctor, Exams);
        order.Display();
        return order;
    }
}