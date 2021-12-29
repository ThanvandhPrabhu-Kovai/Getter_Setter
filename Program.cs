using System;

namespace Getter_Setter
{
    class Program
    {
        static void Main(string[] args)
        {
            showOutput("\n\n");
            Student student = new Student();
            student.Age = 19;
            student.Name = "Student A";
            student.MailAddress = "studentA@mail.com";
            showOutput(student.Age.ToString());
            showOutput(student.Name);
            showOutput(student.MailAddress);
            showOutput("\n\n");
            Animal cat = new Animal();
            cat.Type = "Mammal";
            cat.FamilyName = "Felidae";
            cat.ConsumerType = "Carnivores";
            showOutput(cat.Type);
            showOutput(cat.FamilyName);
            showOutput(cat.ConsumerType);
            showOutput("\n\n");
            Car car = new Car();
            car.Make = "BMW";
            car.Model = "3 Series";
            car.Color = "Black";
            showOutput(car.Make);
            showOutput(car.Model);
            showOutput(car.Color);
            showOutput("\n\n");
            Organization organization = new Organization();
            organization.Name = "Kovai.Co";
            organization.AddressCity = "Coimbatore";
            organization.WebAddress = "www.kovai.co";
            showOutput(organization.Name);
            showOutput(organization.AddressCity);
            showOutput(organization.WebAddress);
            showOutput("\n\n");
            MobilePhone mobilePhone = new MobilePhone();
            mobilePhone.Make = "Nokia";
            mobilePhone.Model = "C2";
            mobilePhone.MobileColor = "White";
            showOutput(mobilePhone.Make);
            showOutput(mobilePhone.Model);
            showOutput(mobilePhone.MobileColor);
            showOutput("\n\n");
            Console.ReadLine();
        }

        static void showOutput(string input) => Console.Write($"{input}\t");
    }

    public class Student
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string MailAddress { get; set; }
    }

    public class Animal
    {
        public string Type { get; set; }
        public string FamilyName { get; set; }
        public string ConsumerType { get; set; }
    }

    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }
    }

    public class Organization
    {
        public string Name { get; set; }

        public string AddressCity { get; set; }

        public string WebAddress { get; set; }
    }

    public class MobilePhone
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string MobileColor { get; set; }
    }
}
