using System;

namespace RunTimePolymorphism
{
    class Program
    {
        // Base Class
        public class BaseClass
        {
            public virtual void GetInfo()
            {
                Console.WriteLine("Base Class Info");
            }
        }

        // Derived Class
        public class DerivedClass : BaseClass
        {
            public override void GetInfo()
            {
                Console.WriteLine("Derived Class Info");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Run Time Polymorphism");
            Console.WriteLine("Polymorphism provides an ability for the classes to implement different methods that are called through the same name ");
            Console.WriteLine("and it also provides an ability to invoke the methods of a derived class through base class reference during runtime based on our requirements.");
            Console.WriteLine("Run Time Polymorphism means overriding a base class method in the derived class by creating a similar function and this can ");
            Console.WriteLine("be achieved by using override & virtual keywords along with inheritance principle.");
            Console.WriteLine("");
            
            DerivedClass d = new DerivedClass();
            d.GetInfo();

            BaseClass b = new BaseClass();
            b.GetInfo();

            Console.ReadLine();
        }
    }
}