using System;

namespace OperatorOverloadingDemo
{
    public class Employee
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"Employee [ID: {Id}, Name: {FirstName} {LastName}]";
        }

        // Custom comparison method instead of overloading
        public bool CompareById(Employee other)
        {
            if (other == null)
                return false;
            return this.Id == other.Id;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var emp1 = new Employee(1, "John", "Doe");
            var emp2 = new Employee(1, "Jane", "Smith");
            var emp3 = new Employee(3, "Alice", "Cooper");

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
            Console.WriteLine(emp3);
            Console.WriteLine();

            Console.WriteLine("Custom comparison:");
            Console.WriteLine($"emp1.CompareById(emp2): {emp1.CompareById(emp2)}");
            Console.WriteLine($"emp1.CompareById(emp3): {emp1.CompareById(emp3)}");

            Console.ReadKey();
        }
    }
}
