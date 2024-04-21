using MVC_APP_DEMO.Controller;
using MVC_APP_DEMO.Model;
using MVC_APP_DEMO.View;

namespace MVC_APP_HELLO_WORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee empModel = new Employee();
            IEmployeeView empView = new EmployeeView();

            empModel.FirstName = "David";
            empModel.LastName = "Brown";
            empModel.EmployeeID = 32567;
            empModel.EmployeeSalary = 90000.00M;

            EmployeeController empController = new EmployeeController(empModel, empView);
            empController.DisplayEmploeeInfo();

            Console.ReadLine();
        }
    }
}