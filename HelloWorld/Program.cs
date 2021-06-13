using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        // writing our own method inside the program class
        // void keyword indicates that this method does not return any value        
        static void MyMethod(string name="John")
        {

            Console.WriteLine($"Program just executed by :{name}");
        }

        // if you want a method to return value use primitive datatypes 
        // such as int or double instead of void and use the return keyword
        // inside of the method.

        static int MyNumber(int x, int y)
        {
            return x+y;
        }



            static void Main(string[] args)
            {
                int num = 34;
                string firstName = "John";
                string secondName = "Delver";
                char myGrade = 'a';
                bool cSharp = true;
                Console.WriteLine(myGrade);
                Console.WriteLine(cSharp);
                Console.WriteLine($"The num is: {num}");
                Console.WriteLine($"Hello World! Full Name is: {firstName + secondName}");

                //string name = string.Concat(firstName, secondName);
                //Console.WriteLine($"My name is: {name}");

                //Type your userName and press Enter

                //Console.WriteLine("Enter username:");
                // create a string variable userName & get the user input from the
                // keyboard and store it in the varible


                //string userName = Console.ReadLine();
                // print the value of userName that users types in the keyboard.
                //Console.WriteLine($"The userName is: {userName}");

                //Console.WriteLine("Enter your age:");
                // Console.ReadLine() method returns a string not an integer
                // thats why here we converted string to an integer
                // int age = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine($"The age written is: {age}");


                string txt = "hello";
                string txt1 = "HOW";
                Console.WriteLine($"The string is : {txt.ToUpper()}");
                Console.WriteLine($"The string is : {txt1.ToLower()}");

                int x = 10;
                int y = 9;
                if (x > y)
                {
                    Console.WriteLine($"x is greater than y");
                }
                else
                {
                    Console.WriteLine($"y is greater than x");
                }

                // Terenary operator instead of if else statement

                string result = (x > y) ? "Good Day" : "Good evening";
                Console.WriteLine(result);

                //int day = 3;

                //switch (day)
                //{
                //    case 1:
                //        Console.WriteLine("Today is sunday");
                //        break;
                //    case 2:
                //        Console.WriteLine("Today is saturday");
                //        break;
                //    case 3:
                //        Console.WriteLine("Today is Monday");
                //        break;
                //    default:
                //        Console.WriteLine("Today is Wednesay");
                //        break;

                //}

                string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
                Array.Sort(cars);

                foreach (string car in cars)
                {
                    Console.WriteLine(car);
                }
                Console.WriteLine(cars.Length);


                int[] numbers = { 1, 2, 3, 4, 5 };
                int largest = numbers.Max();

                Console.WriteLine($"Largest number is: {largest}");
                Console.WriteLine($"Smallest number is: {numbers.Min()}");

                // calling method with parameter
                MyMethod("Boss");
                // calling method without parameter
                MyMethod();

                Console.WriteLine(MyNumber(5, 3));

                Car Ford = new Car("Mustang","red",1988);
                //Ford.color = "red";
                //Ford.model = "Mustang";
                //Ford.year = 1968;

                Car Opel = new Car("Opel","black",1990);
            //Opel.model = "Astra";
            //Opel.color = "blue";
            //Opel.year = 1969;

                Console.WriteLine(Ford.model);
        
            Console.WriteLine(Opel.model);

            Person myobj = new Person();
            myobj.Name = "Boss";
            myobj.Address = "Newyork";

            Console.WriteLine($"Name is : {myobj.Name}");
            Console.WriteLine($"Address is : {myobj.Address}");

          // created a List of object means array of oobjects using
          // the class Student
            var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };

       

            //Console.WriteLine(students[0].Name);
            //Console.WriteLine(students[1].Name);

            //OR

            foreach(var stud in students)
            {
                Console.WriteLine(stud.Name);
                Console.WriteLine(stud.Id);
            }


            //var numberss = new List<int>() { 1, 2, 3, 4, 5, 5 };

            //foreach (var nums in numberss)
            //{
            //    Console.WriteLine(nums);
            //}


           
            }
        }
          

        
    } 
    

