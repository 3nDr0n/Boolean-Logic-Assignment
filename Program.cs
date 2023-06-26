using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car insurance application");  //Displays Title
            Console.WriteLine("What is your age?");  //Displays First question
            int age = Convert.ToInt32(Console.ReadLine());  //Creates variable vith value given by user, converted to int32
            Console.WriteLine("Have you ever had a DUI? Please answer with yes or no!");
            string answer = Console.ReadLine().ToLower();  //  //Creates variable vith value given by user converted to lovercase
            bool dui = answer == "yes";  //Creates boolean variable and the value will be either true or false depending on previous variable value
            Console.WriteLine("How many speeding tickets do you have?");  
            int tickets = Convert.ToInt32(Console.ReadLine());  //Creates variable vith value given by user, converted to int32
            Console.WriteLine("Qualified for insurance?");  
            bool qualified = (age > 15) && !dui && (tickets <= 3);  //Creates boolean variable and the value will be either true or false depending on previous variable values
            Console.WriteLine(qualified);
            Console.ReadLine(); 
        }
    }
}
