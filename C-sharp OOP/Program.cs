using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_OOP
{
    /* class Car                          //1st example
     {
         public string model;             //fields
         public Car()                    //constructors
         {
             model = "Mustang";
         }
         public void DisplayModel()       //methods
         {
             Console.WriteLine(model);
         }
     }
     class Program
     {
         static void Main(string[] args)
         {
             Car mycar = new Car();
             mycar.DisplayModel();
         }
     }
 */

    /* class Circle                           // Second Example
     {
         double _radius;                    // 2 fields of circle or objects
         double pi;
         public Circle(double radius)      //constructor of the class circle
         {
             pi = 3.14159;
             _radius = radius;
         }
         public double CalcuateArea()       //method
         {
             double area = pi * _radius * _radius;
             return area;
         }

     }
     class Program
     {
         static void Main(string[] args)
         {
             Circle myCircle = new Circle(4);
             Circle secondCircle = new Circle(5.8);
             Console.WriteLine(myCircle.CalcuateArea());
             Console.WriteLine(secondCircle.CalcuateArea());

         }
     }*/
    

    // Encapsulation - get and set method
    class Person
    {
        private string firstname; //field
        private string lastname;
        public string FirstName  //property
        {
            get { return firstname; }   //get method
            set { firstname = value; }     //set method
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string FullName
        {
            get
            {
                return $"{firstname}{lastname}";
            }
        }
        public void DisplayFullName()
        {
            Console.WriteLine($"{firstname}{lastname}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.LastName = " Oladejo";
            person.FirstName = "Abimbola";
            Console.WriteLine(person.FullName); 
        }


    }
}


