using System;
namespace AbstractClass
{
    abstract class EmpName
    {

        protected string name;
        public abstract string Name
        {
            get;
            set;
        }
    }
    class EmpFirstName : EmpName
    {
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // create an object of Dog class
            EmpFirstName obj = new EmpFirstName();
            obj.Name = "Akash";
            Console.WriteLine("Name: " + obj.Name);

            Console.ReadLine();
        }
    }
}