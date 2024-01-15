using System.Xml.Schema;

namespace GA_Constructors_MatthewVargas
{
    internal class Program
    {

        //Matthew Vargas
        //A constructor contains a set of fields, allowing other code to organize information as objects in its model

        //Example:
        class Phone
        {
            public string type; //Field
            public Phone() //Constructor (Default)
            {
                type = "Ipad"; //A default contructor is the essentials of Constructors, a defined value for a chosen field
            }

            public Phone(string phoneType) //Custom constructor
            { 
                type = phoneType; //Custom constructors can customize a default for the object, normal constructors lack that functionality
            }

            public Phone(string phonetype, int version) //This is an example of an overloaded constructor already, having multiple contructors in this one class "program"
            {
                type = $"{phonetype} - Version {version}"; //With multiple string and int values avaliable at once in the same class objects are more adaptable and flexible
            }

            public Phone(string phoneType, int version, string color) //Fields for initialization
            {
                type = $"{phoneType} - Version {version} ({color})"; //Initializing fields in constructors is important as it allows them to gain a value or place for utilization on entry
            }
               
            static void Main(string[] args) //Object creation 
            {
                Phone Default = new Phone();
                Phone custom = new Phone("iPhone");
                Phone overloaded = new Phone("Samsung", 2);
                Phone fields = new Phone("Google", 3, "Black"); //Others are labeled, this has multiple parameters to signify the last question
            
                //Next question

                Console.WriteLine("Default Phone: " + Default.type); //One value allowed
                Console.WriteLine("Custom Phone: " + custom.type); //One value
                Console.WriteLine("Overloaded Phone: " + overloaded.type); //Wider variety of objects
                Console.WriteLine("Multi Phone: " + fields.type); //More descriptive \ More information held

            }

        }
    }
}
