using MVC_APP_DEMO.Model;
using MVC_APP_DEMO.View;

namespace MVC_APP_DEMO.Controller
{
    class EmployeeController
    {
        private IEmployee empModel;
        private IEmployeeView empView;

        public EmployeeController(IEmployee emp, IEmployeeView empView)
        {
            this.empModel = emp;
            this.empView = empView;
        }

        public void DisplayEmploeeInfo()
        {
            empView.DisplayEmploeeView(this.empModel);
        }

        public void UpdateEmployeeSalary(Decimal salary)
        {
            this.empModel.EmployeeSalary = salary;
        }
    }
}