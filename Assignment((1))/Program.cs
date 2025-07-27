namespace Assignment__1__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part 1
            //1.Create a struct called "Point" to represent a 2D point with properties "X" and
            //"Y".Write a C# program that takes two points as input from the user and
            //calculates the distance between them.
            //Point point=new Point(4,5,3,2);
            //point.result();


            //////////////////////////////////////////////////////////////////////////
            ///2.Create a struct called "Person" with properties "Name" and "Age". Write a C#
            //program that takes details of 3 persons as input from the user and displays the
            //name and age of the oldest person.

            //Console.WriteLine("Enter first name ");
            //string name1 = Console.ReadLine();
            //Console.WriteLine("Enter first age ");
            //int age1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter scond name ");
            //string name2 = Console.ReadLine();
            //Console.WriteLine("Enter scond age ");
            //int age2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter third name ");
            //string name3 = Console.ReadLine();
            //Console.WriteLine("Enter third age ");
            //int third = int.Parse(Console.ReadLine());
            //person person = new person(name1, age1, name2, age2, name3, third);
            //person.result();
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Part 02
            // Design and implement a Class for the employees in a company:
            //Notes:
            //● Employee is identified by an ID, Name, security level, salary, hire date
            //and Gender.
            //● We need to restrict the Gender field to be only M or F[Male or Female]
            //● Assign the following security privileges to the employee(guest,
            ////Developer, secretary and DBA) in a form of Enum.
            ////● We want to provide the Employee Class to represent Employee data in a
            ////string Form(override ToString()), display employee salary in a currency
            ////format. [Use String.Format() Function].

            //Employee emp = new Employee(101,"Mohamed",Gender.Male,100000, new DateTime(2003, 11, 10), Security_Level.Developer);
            //Console.WriteLine(emp);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///0. Develop a Class to represent the Hiring Date Data: ● Consisting of fields to hold the day, month and Years.
            //Console.WriteLine("Enter Hiring Date Data");
            //int day, month, year;
            //Console.Write("Enter Day: ");
            //day = int.Parse(Console.ReadLine());
            //Console.Write("Enter Month: ");
            //month = int.Parse(Console.ReadLine());
            //Console.Write("Enter Year: ");
            //year = int.Parse(Console.ReadLine());
            //HiringDate hiringDate = new HiringDate(day, month, year);
            //Console.WriteLine($"Hiring Date: {day}/{month}/{year}");

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Create an array of Employees with size three a DBA, Guest and
            // the third one is security officer who have full permissions. (Employee
            //[] EmpArr;)
            //Notes:
            //● Implement All the Necessary Member Functions on the Class
            //(Getters, Setters)
            //● Define all the Necessary Constructors for the Class
            //● Allow NO RUNTIME errors if the user inputs any data
            //● Write down all the necessary Properties(Instead of setters
            ////and getters)
            //Employee2[] EmpArr = new Employee2[3];

            //EmpArr[0] = new Employee2(1, "Ahmed", SecurityLevel.DBA, 20000, new HiringDate(1, 1, 2021), 'M', Permissions.Write);
            //EmpArr[1] = new Employee2(2, "Mona", SecurityLevel.Guest, 5000, new HiringDate(5, 6, 2023), 'F', Permissions.Read);
            //EmpArr[2] = new Employee2(3, "Khaled", SecurityLevel.SecurityOfficer, 25000, new HiringDate(10, 10, 2020), 'M', Permissions.Delete);

            //foreach (var emp in EmpArr)
            //{
            //    Console.WriteLine(emp);
            //}
        }
    }
}
