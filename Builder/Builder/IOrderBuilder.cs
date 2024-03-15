namespace Training_C_.Builder;

public interface IOrder
{
    string AddPatient(string patient);

    string AddHealthPlan(string healthPlan);

    string AddDoctor(string doctor);

    List<string> AddExams(List<string> Exams);

    int AddOrderId(int orderId);

    object GetOrder();
}