using System;
using System.Collections.Generic;
namespace PA1_MiguelReveles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring new Grad Student List and Under Grad Student list
            List<GradStudent> gradList = new List<GradStudent>();
            List<UnderGradStudent> undergradList = new List<UnderGradStudent>();
            //declaring variables
            int response;
            bool continuar = true;
            string compResponse;

            while (continuar)
            {
                Console.WriteLine("Select a Task (Please Enter A Number)");
                Console.WriteLine("\t1. Add Grad Student \n\t2. Add Under Grad Student \n\t3. List All Grad Students");
                Console.WriteLine("\t4. List All Under Grad \n\t5. EXIT");
                response = int.Parse(Console.ReadLine());
                switch(response)
                {
                    case 1:
                        compResponse = "Add Grad Student";
                        Console.WriteLine("You entered {0}.",compResponse);
                        break;
                    case 2:
                        compResponse = "Add Under Grad Student";
                        Console.WriteLine("You entered {0}.", compResponse);
                        break;
                    case 3:
                        compResponse = "List All Grad Students";
                        Console.WriteLine("You entered {0}.", compResponse);
                        break;
                    case 4:
                        compResponse = "List All Under Grad Students";
                        Console.WriteLine("You entered {0}.", compResponse);
                        break;
                    case 5:
                        continuar = false;
                        break;
                }
            }
        }
    }
}
