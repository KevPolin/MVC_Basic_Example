MVC Design Pattern
What is MVC Pattern ?
MVC stands for Model-View-Controller (MVC), it is a software design pattern that decouples various concerns in an application.

It is a powerful and effective way of designing applications that separates the UI (User Interface) logic from the data access and data manipulation logic.
It’s explicit separation of concerns adds some extra complexity to an application’s design, but it provides enormous benefits to the application’s stability, functionality and testability.
Why MVC Pattern ?
The MVC separates an application into three main aspects:

Model: A set of classes, which are basically the data you’re working with along with the business logic and rules that describes how the data can be manipulated.
View: It defines the UI of the application, in other words it’s the representation of the data that model contains.
Controller: A set of classes that handles user input and  acts upon the model to generate required view.

MVC Pattern
If you look at the above diagram, In a typical MVC design pattern. The end User interacts with the View, which is basically the UI layer. Upon the user action e.a user clicks any button or mouse hover event, the View invokes corresponding Controller. The controller then determines the Model and updates it as per the requirement. Once the Model is updated then the Controller generates the View and updates it for the end user.

Lets look at the example code below, that uses the MVC pattern to display the Employee detail.

EmployeeView.CS – This file has an Interface as  IEmployeeView and a view  class as EmployeeView, that implements the interface IEmployeeView.
Employee.CS – This file has an Interface as  IEmployee and a model as Employee, that implements the interface IEmployee.
EmployeeController.CS – This file has the controller as EmployeeController.
Program.CS - This file creates an Employee and an Employee View, assigns values to the employee model properties. Then creates a new controller which displays the Employee Info.
