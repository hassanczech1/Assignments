using System;
using System.Collections.Generic;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(10);
            IVehicle vehicle = myCar;
            vehicle.Drive();
            vehicle.Refuel(20);
            vehicle.Drive();
            IDrivable drivable = myCar;
            drivable.Move();
            drivable.Accelerate();
            drivable.Drive();

            Stack<int> stack = new Stack<int>(5);
            stack.Push(10);
            stack.Push(20);
            Console.WriteLine(stack.Pop());

            Student[] students = new Student[5];
            students[0] = new Student { ID = 3, Name = "Ahmed" };
            students[1] = new Student { ID = 2, Name = "Hassan" };
            students[2] = new Student { ID = 5, Name = "Hussien" };
            students[3] = new Student { ID = 1, Name = "Abdo" };
            students[4] = new Student { ID = 4, Name = "Eslam" };
            Array.Sort(students);

            try
            {
                students[5] = new Student { ID = 6, Name = "Karam" };
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Cannot add new student: " + ex.Message);
            }

            GList<int> intList = new GList<int>();
            intList.Add(10);
            intList.Add(20);
            intList.DisplayItems();

            List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Sameh", Salary = 9000, Experience = 6 },
            new Employee { Id = 2, Name = "Hosam", Salary = 12000, Experience = 4 },
            new Employee { Id = 3, Name = "Ashraf", Salary = 8000, Experience = 7 }
        };
            List<Employee> promotedEmployees = Promotion.Promote(employees, emp => emp.Salary < 10000);
            foreach (var emp in promotedEmployees)
            {
                Console.WriteLine($"Promoted: {emp.Name}");
            }

            Calculator calc = new Calculator();
            CalculateDelegate del = calc.Sum;
            del += calc.Subtract;
            del += calc.Multiply;
            del += calc.Divide;

            del.Invoke(10, 5);

            Product product1 = new Product { ID = 1, Name = "Laptop" };
            Supplier supplier = new Supplier { ID = 1, Name = "Supplier" };
            Company company = new Company();
            company.AddProduct(product1, 10);
            company.SellProduct(product1, 7);
        }
    }
}
