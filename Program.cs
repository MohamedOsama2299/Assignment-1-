namespace Demo__1__
{
    //class
    //struct
    //interface
    //enum
    /// ///////////////////////
    /// struct :value type :stack

    //employee 
    //id,mname,salary
    //
    internal class Program
    {
        static void Main(string[] args)
        {
            //point
            //point p01;
            //////declare for object from type 'point'
            //////p01:object 
            //////// Allocate unInitialized 8 bytes at stack

            //////Console.WriteLine(p01.x);
            //////Console.WriteLine(p01.y);
            ////p01.x = 12;
            ////p01.y = 12;
            ////Console.WriteLine(p01.x);
            ////Console.WriteLine(p01.y);
            //p01 = new point(1,2);
            //Console.WriteLine(p01);
            //new :used for select the constructor 
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //oop : Object Oriented Programing
            //Programming Pardiom
            //oop :the paediom Use for Build Anny Business
            // class :blueprint for object
            //object :specific instance of class
            //4 pillars `   
            //======================
            //1. Encapsulation 
            //2. Inheritance 
            //3. Polymorphism 
            //4. Abstraction 
            //===================================================================================//
            //1 encapsulation
            //Encapsulation :the process of hiding the implementation details and showing only the essential features of the object.
            // seperate the data (Atributes) defition grom its use
            //Employee
            //id,name,salary

            //1.end user Access data itself
            // 2. No data validation
            //3. No read only Field

            //apply Encapsulation
            //1. Make all data private
            //2. Access data trhough 
            //2.1. setter getter method
            //2.2. properties

            //Employee E01 = new Employee();
            //E01.Id = 1;
            //E01.Name = "Ahmed";
            //E01.Salary = 12000;
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);
            //Console.WriteLine(E01.Id);

            //E01.SetName("Ahmed");
            ////E01.SetSalary(100000);
            //Employee E01 = new Employee();
            //E01.NAME = "Ahmed";
            ////Console.WriteLine(E01.NAME);
            ////E01.Address = "Cairo";
            ////Console.WriteLine(E01.Address);
            //PhoneBook phoneBook = new PhoneBook(3);
            //phoneBook.AddPerson("Ahmed", 111, 0);
            //phoneBook.AddPerson("Ali", 222, 1);
            //phoneBook.AddPerson("omar", 333, 2);
            //Console.WriteLine(phoneBook.GetNumber("Ahmed"));
            //Console.WriteLine(phoneBook["Ahmed"]); //long
            //phoneBook["Ahmed"] = 111; //long

            //Car c01;
            //c01 = new Car(1, 200, "xyz");
            ////new
            ////1. allocate the number of required Bytes At Heap for the object
            ////2.Initialize the Allocated Bytes with default values of the Data Types
            ////3. call user defined constructor if exist
            ////4. assign the object reference 

            //Console.WriteLine(c01.Id);
            //declare for refernce from type 'Car'
            //c01: Can Refer to an object from type 'Car' or any classInherited from 'Car'
            //c01 :Refer to null
            //cwriteLine(c01); 
            //8 Bytes will be allocated at stack for the Refernce 'c01'
            //0 Bytes will be allocated at heap 
        }
    }
}
