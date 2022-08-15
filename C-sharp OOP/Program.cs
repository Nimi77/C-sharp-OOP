using System;
using System.Collections.Generic;
using System.Linq;   
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_OOP
{
    //Encapsulation refers to the bundling of data, along with methods that operate on that data, into a single unit 
    //A class is a program-code template that allows developer to create an object that has both variables(data) and behaviours (functions or methods)
    /*    class Person
        {
            public string name;
            public Person(string name)
            {
                this.name = name;
            }
            public void WriteYourName()
            {
                Console.WriteLine($"My name is {name}");
            }
        }
        class Student : Person                           //Inheritance
        {
            public string myname;
            public Student(string name) : base(name)
            {
                myname = name;
            }
            public void Study()
            {
                Console.WriteLine($"{name} is studying");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Person myPerson = new Person("Toluwanimi");
                myPerson.WriteYourName();

                Student mystudent = new Student("Adewuyi");
                mystudent.WriteYourName();
                mystudent.Study();


            }
        }*/

    /*    class Person                   // Encapsulation - get and set method
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
        }*/

    //Inheritance is a mechanism that allows one class to gain the properties of another class, in the same way, that a child inherits
    //some attributes from each other
    /*    class Vehicle                     //Inheritance - base class
    {
        public string brand = "Ford";
        public string colour = "Blue";
        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
    class Car : Vehicle  //derived class
    {
        public string ModelName = "Lexus"; //car field
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car();
            Car myCarColour = new Car();
            mycar.honk();
            Console.WriteLine(mycar.brand + " " + mycar.ModelName + ".The colour is " + myCarColour.colour);

        }
    }*/

    /*  class Animal                                     //Polymorphism
               {
                   public virtual void animalsound()
                   {
                       Console.WriteLine("The animal makes a sound");
                   }
               }
               class Pig : Animal
               {
                   public override void animalsound()
                   {
                       Console.WriteLine("The pig says : wee wee");
                   }
               }
               class Dog : Animal
               {
                   public override void animalsound ()
                   {
                       Console.WriteLine("The dog says : gboo gboo");
                   }

               }
               class Program
               {
                   static void Main(string[] args)
                   {
                       Animal myAnimal = new Animal(); //an instance of the animal class
                       Animal myPig = new Pig();
                       Animal myDog = new Dog();    //create a dog subject

                       myAnimal.animalsound();
                       myPig.animalsound();
                       myDog.animalsound();

                   }
               }*/

    //Abstraction occurs when a programmer hides any irrevelant data about an object or an instantiated class to reduce complexity and help
    //users interact with a program
    //Interface is another way to achieve abstraction in csharp
    //It defines what sort of behaviour a certain object must exhibit, without specifying  how this behaviour should be implemented.
    //They are also known as Contracts or specification of behaviour. 

    /*    interface Animal
        {
            bool CanFly { get; set; }
            void animalmakesound(); //interace method does not have body
        }
        class Cow : Animal
        {
            public bool CanFly { get; set; }
            public Cow()
            {
                CanFly = false;
            }
            public void animalmakesound()
            {
                Console.WriteLine("A cow moos");
            }
        }
        interface Livingthings
        {
            bool HasFourLegs { get; set; }
            void Reproduce (string youngOne);
            void Move();
        }
        class Bird : Animal,Livingthings
        {
            public bool CanFly { get; set; }
            public bool HasFourLegs{ get; set; }
            public Bird()
            {
                CanFly = true;
                HasFourLegs = false;
            }
            public void animalmakesound()
            {
                Console.WriteLine("A bird chirps");
            }
            public void Move()
            {
                Console.WriteLine("A birld can fly");
            }
            public void Reproduce (string youngOne)
            {
                Console.WriteLine($"Baby birds are called {youngOne}");
            }
            public bool CanItFly()
            {
                return CanFly;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Cow myCow = new Cow();
                Console.WriteLine($"Can a cow fly? True/False...{myCow.CanFly}");
                myCow.animalmakesound();

                Bird myBird = new Bird();
                myBird.animalmakesound();
                Console.WriteLine(myBird.CanFly);
                Console.WriteLine(myBird.HasFourLegs);
                myBird.Move();

                Console.WriteLine("What does a bird Reproduce?");
                string youngBird = Console.ReadLine();
                myBird.Reproduce(youngBird);
                bool response = myBird.CanItFly();
                Console.WriteLine(response);

            }
        }*/

    /*   abstract class HigherAnimal    // Abstraction
     {
         public HigherAnimal()
         {
         } //Abstract class does not have a body

         public abstract void AnimalType();
         //regular method
         public void Mammal()
         {
             Console.WriteLine("Gender");
         }
     }
     class Male : HigherAnimal
     {
         public override void AnimalType()
         {
             Console.WriteLine("Male- Masculine, responsible ");
         }
     }
     class Female : HigherAnimal
     {
         public override void AnimalType()
         {
             Console.WriteLine("Female- Feminine, unique, soft");
         }
     }

     class Program
     {
         static void Main(string[] args)
         {
             Male mymale = new Male();
             mymale.AnimalType();
             mymale.Mammal();

             Female myfemale = new Female();
             myfemale.AnimalType();
             myfemale.Mammal();


         }
     }*/

    /* //Test 6
     abstract class Shape
     {
         public Shape() { }
         abstract public int CalculateSurface();
         public void surface()
         {
             Console.WriteLine("Area of the triangle is");
         }

     }
     class Triangle : Shape
     {
         int width;
         int height;
         public Triangle()
         {
             width = 4;
             height = 6;
         }
         public override int CalculateSurface()
         {
             return height * width / 2;
         }
     }
     class Rectangle : Shape
     {
         int width;
         int height;
         public Rectangle()
         {
             width = 12;
             height = 2;
         }
         public override int CalculateSurface()
         {
             return height * width;
         }
     }
     class Program
     {
         static void Main(string[] args)
         {
             Triangle myTriangle = new Triangle();
             myTriangle.surface();
             Console.WriteLine(myTriangle.CalculateSurface());

             Rectangle myRectangle = new Rectangle();
             myRectangle.surface();
             Console.WriteLine(myRectangle.CalculateSurface());


         }
     }*/

  /*  //Lab Test 6
    abstract class Shape
    {
        protected double width;
        protected double height;


        public Shape(double Width)
        {
            width = height = Width;
        }
        public Shape(double Width, double Height)
        {
            width = Width;
            height = Height;
        }

        public abstract double CalculateSurface();
    }
    class Triangle : Shape
    {
        public Triangle(double Width, double Height) : base(Width, Height)
        { }
        public override double CalculateSurface()
        {
            return height * width / 2;
        }
    }
    class Rectangle : Shape
    {
        public Rectangle(double Width, double Height) : base(Width, Height)
        { }
        public override double CalculateSurface()
        {
            return height * width;
        }
    }
    class Circle : Shape
    {
        public Circle(double Radius) : base(Radius)
        { }
        public override double CalculateSurface()
        {
            return Math.PI * Math.Pow(width, 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Triangle myTriangle = new Triangle(4, 2);
            myTriangle.CalculateSurface();
            Console.WriteLine(myTriangle.CalculateSurface());

            Rectangle myRectangle = new Rectangle(2, 4);
            myRectangle.CalculateSurface();
            Console.WriteLine(myRectangle.CalculateSurface());

            Circle myCircle = new Circle(4);
            myCircle.CalculateSurface();
            Console.WriteLine(myCircle.CalculateSurface());


        }
    }*/

    //Exceptions
    //Exceptions are unwanted events that may arise during runtime i.e DivideByZero, OutOfMemory, IndexOutOfBound, StackOverFlowException
    //Try and Catch bllock - Catch block handles the exception raised in the try block

    public class Geeks
    {
        public string Author_name { get; set; }
    }
    class TestFinally
    {
        public void B()
        {
            try
            {
                Console.WriteLine("Inside B");
                return;
            }
            finally
            {
                Console.WriteLine("B's finally");
            }
        }
    }
    class Program
    {
        public static void Main(string[]args)
        {
            //To show the occurrence of exception during Divide By Zero operation 
            int[] number = { 8, 17, 24, 5, 25 };
            int[] divisor = { 2, 0, 0, 5 };
            try
            {
                int A = 8;
                int B = 0;
                //divide by zero error
                int C = A / B;

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("An error occured");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occured...{ex.Message}...{ex.InnerException}");
            }

            //......try block....
            for ( int j = 0; j < number.Length; j++ )

            //This block raises two different type of exception
            //Which are: DivideByZeroException and IndexOuutOfRangeException
            try
            {
                Console.WriteLine("Number:" + number[j]);
                Console.WriteLine("Divider:" + divisor[j]);
                Console.WriteLine("Quotient:" + number[j]/divisor[j]);
            }
            //Catch block 1
            catch (DivideByZeroException)
            {
                Console.WriteLine("Not possible to Divide by Zero");
            }
            //Catch block 2
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index is out  of range");
            }

            //Nesting of Try and Catch block
            

        }

       
    }



}







