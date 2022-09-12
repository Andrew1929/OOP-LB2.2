using System;

namespace OOP_LB2._2
{
    class Employee
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private string Job { get; set; }
        private int Experience { get; set; }
        
        public Employee(string name ,string surname,string job,int experience)
        {
            this.Name = name;
            this.Surname = surname;
            this.Experience = experience;
            this.Job = job;
            double salary;
            if(job == "software engineer")
            {
                salary = 1200;
                Console.WriteLine($"Name: {Name} {Surname}\n" +
             $"Salary : {salary = salary + (200 * experience)}$\n" +
             $"ПДФО :{salary * 0.18} ВЗ: {salary * 0.015 } ПСП: {salary * 0.22}");
            }
            else if(job == "designer")
            {
                salary = 900;
                Console.WriteLine($"Name: {Name} {Surname}\n" +
             $"Salary : {salary = salary +(100 * experience)}$\n" +
             $"ПДФО :{salary * 0.18} ВЗ: {salary * 0.015 } ПСП: {salary * 0.22}");
            }
            else if(job == "3d artist")
            {
                salary = 850;
                Console.WriteLine($"Name: {Name} {Surname}\n" +
             $"Salary : {salary = salary + (150 * experience)}$\n" +
             $"ПДФО :{salary * 0.18}$ ВЗ: {salary * 0.015 }$ ПСП: {salary * 0.22}$");
            }
            else
            {
                Console.WriteLine("the job you entered isn't in the list");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name : ");
            string name  = Console.ReadLine();
            Console.Write("Surname : ");
            string surname = Console.ReadLine();
            Console.Write("Job (software engineer , designer , 3d artist): ");
            string job = Console.ReadLine();
            Console.Write("Experience (in years) : ");
            int experience = Convert.ToInt32(Console.ReadLine());
            Employee employee = new Employee(name, surname,job,experience);
            Console.ReadKey();
        }
    }
}
