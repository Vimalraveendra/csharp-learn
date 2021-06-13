using System;
namespace HelloWorld
{
    public class Car // created class
    {

        // access modifiers private, public, protect,internal.
        public string model;  // created field
        public string color;   // created field
        public int year;       // created field
        public void fullThrottle()    // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        // create class contructor
        public Car(string modelName, string modelColor,int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
    
    }
}
    