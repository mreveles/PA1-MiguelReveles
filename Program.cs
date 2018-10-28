using System;
using System.Collections.Generic;
using System.IO;

namespace CA1_MiguelReveles
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //Declaring new Grad Student List and Under Grad Student list
            List<GradStudent> gradList = new List<GradStudent>();
            List<UnderGradStudent> undergradList = new List<UnderGradStudent>();
            //declaring variables
            bool continuar = true;
            string compResponse;

            while (continuar)
            {
                Console.WriteLine("Select a Task (Please Enter A Number)");
                Console.WriteLine("\t1. Add Grad Student \n\t2. Add Under Grad Student \n\t3. List All Grad Students");
                Console.WriteLine("\t4. List All Under Grad \n\t5. EXIT");
                var response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        compResponse = "Add Grad Student";
                        string TstdName;
                        string TDOB;
                        long TID = 0;
                        string TMjr;
                        float TGPA;
                        string TprvDegree;
                        string TprvUniversity;
                        string TundrgdMjr;
                        float TundergdGPA;

                        Console.WriteLine("Enter Student Name:");
                        TstdName = Console.ReadLine();
                        Console.WriteLine("Date of Birth:");
                        TDOB = Console.ReadLine();
                        Console.WriteLine("ID");
                        var respuesta = Console.ReadLine();
                        TID = testlong(respuesta);
                        Console.WriteLine("Major:");
                        TMjr = Console.ReadLine();
                        Console.WriteLine("Undergraduate GPA:");
                        respuesta = Console.ReadLine();
                        TGPA = testfloat(respuesta);
                        Console.WriteLine("Previous Degree:");
                        TprvDegree = Console.ReadLine();
                        Console.WriteLine("Previous University:");
                        TprvUniversity = Console.ReadLine();
                        Console.WriteLine("Undergraduate Major:");
                        TundrgdMjr = Console.ReadLine();
                        Console.WriteLine("Undergraduate GPA:");
                        respuesta = Console.ReadLine();
                        TundergdGPA = testfloat(respuesta);
                        gradList.Add(new GradStudent(TstdName, TDOB, TID, TMjr, TGPA, TprvDegree, TprvUniversity, TundrgdMjr, TundergdGPA));
                        Console.WriteLine("You entered {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", TstdName, TDOB, TID, TMjr, TGPA, TprvDegree, TprvUniversity, TundrgdMjr, TundergdGPA);
                        break;
                    case "2":
                        compResponse = "Add Under-Grad Student";
                        Console.WriteLine("You entered {0}.", compResponse);
                        break;
                    case "3":
                        compResponse = "List All Grad Students";
                        foreach (GradStudent stu in gradList)
                        {
                            stu.displayStdInfo();
                        }
                        Console.WriteLine("You entered {0}.", compResponse);
                        break;
                    case "4":
                        compResponse = "List All Under Grad Students";
                        Console.WriteLine("You entered {0}.", compResponse);
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Input is not readable.");
                        break;
                }
            }
        }
        public static long testlong(string aNum)
        {
            bool check = true;
            long acceptable=00;
            do
            {
                if (long.TryParse(aNum, out long number1))
                {
                    acceptable = number1;
                    check =false;
                }
                else
                {
                    Console.WriteLine($"***{aNum} is not a compatible check your work.***");
                    Console.WriteLine("Enter Again:");
                    aNum = Console.ReadLine();
                }
            } while (check);
            return acceptable;
        }
        public static float testfloat(string aNum)
        {
            bool check = true;
            float acceptable=00;
            do
            {
                if (float.TryParse(aNum, out float number1))
                {
                    acceptable = number1;
                    check =false;
                }
                else
                {
                    Console.WriteLine($"***{aNum} is not a compatible check your work.***");
                    Console.WriteLine("Enter Again:");
                    aNum = Console.ReadLine();
                }
            } while (check);
            return acceptable;
        }
    }
}
