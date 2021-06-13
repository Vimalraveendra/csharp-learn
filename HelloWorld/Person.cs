using System;
namespace HelloWorld
{
    public class Person
    {
        private string name;
        private string address;
    // private string name  only access inside this class Person
    // to access outside and update the string name using propery method
    // get and set
    
    public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // short hand property
        public string Address
        {
            get; set;
        }

    }
}
