using System;
using System.Collections.Generic;
using System.IO;

namespace CA1_MiguelReveles
{
    // public enum Classifaction {Freshman, Sophmore, Junior, Senior};

    public class Program
    {
        static void Main(string[] args)
        {
            //Declaring new Grad Student List and Under Grad Student list
            List<GradStudent> gradList = new List<GradStudent>();
            List<UnderGradStudent> undergradList = new List<UnderGradStudent>();

            //extracts data from txt files
             string[] gradStudentsText = System.IO.File.ReadAllLines(@"GradStudents.txt");
             string[] undergradStudentsText = System.IO.File.ReadAllLines(@"UnderGradSTudents.txt");

            //inputs data from string array into list
            foreach(string gradData in gradStudentsText)
            {
                string[] gradDATA = gradData.Split(',');
                // foreach(string a in gradDATA){
                //     Console.WriteLine(a);
                // }
                var newgraddata = new GradStudent(gradDATA[0],gradDATA[1],long.Parse(gradDATA[2]),gradDATA[3],float.Parse(gradDATA[4]),gradDATA[5],gradDATA[6],gradDATA[7],float.Parse(gradDATA[8]));
                gradList.Add(newgraddata);
            }
            foreach(string ugdata in undergradStudentsText)
            {
                string[] ugDATA = ugdata.Split(',');
                var newUnderudDATA = new UnderGradStudent(ugDATA[0],ugDATA[1],long.Parse(ugDATA[2]),ugDATA[3],float.Parse(ugDATA[4]),ugDATA[5],int.Parse(ugDATA[6]));
                undergradList.Add(newUnderudDATA);
            }
            
            //declaring variables
            bool continuar = true;
            string compResponse;
            string TstdName;
            string TDOB;
            long TID = 0;
            string TMjr;
            float TGPA;
            string TprvDegree;
            string TprvUniversity;
            string TundrgdMjr;
            float TundergdGPA;
            string TpvsHschool;
            float TstdClass;

            //start menue
            while (continuar)
            {
                Console.WriteLine("Select a Task (Please Enter A Number)");
                Console.WriteLine("\t1. Add Grad Student \n\t2. Add Under Grad Student \n\t3. List All Grad Students");
                Console.WriteLine("\t4. List All Under Grad \n\t5. EXIT");
                var response = Console.ReadLine();
                switch (response)
                {
                    //enter grad student
                    case "1":
                        compResponse = "Add Grad Student";
                        Console.WriteLine("\tYou entered {0}", compResponse);
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
                    //enter under grad student
                    case "2":
                        compResponse = "Add Under-Grad Student";
                        Console.WriteLine("\tYou entered {0}", compResponse);
                        Console.WriteLine("Enter Student Name:");
                        TstdName = Console.ReadLine();
                        Console.WriteLine("Date of Birth:");
                        TDOB = Console.ReadLine();
                        Console.WriteLine("ID");
                        respuesta = Console.ReadLine();
                        TID = testlong(respuesta);
                        Console.WriteLine("Major:");
                        TMjr = Console.ReadLine();
                        Console.WriteLine("Undergraduate GPA:");
                        respuesta = Console.ReadLine();
                        TGPA = testfloat(respuesta);
                        Console.WriteLine("Previous HighSchool:");
                        TpvsHschool = Console.ReadLine();
                        Console.WriteLine("Student Class: 1. Freshman, 2. Sophmore, 3. Junior, 4. Senior");
                        respuesta = Console.ReadLine();
                        TstdClass = (int)testfloat(respuesta);
                        undergradList.Add(new UnderGradStudent(TstdName, TDOB, TID, TMjr, TGPA, TpvsHschool, (int)TstdClass));
                        Console.WriteLine("You entered {0}, {1}, {2}, {3}, {4}, {5}, {6}", TstdName, TDOB, TID, TMjr, TGPA, TpvsHschool, TstdClass);                        break;
                    //list grad students
                    case "3":
                        compResponse = "List All Grad Students";
                        foreach (GradStudent stu in gradList)
                        {
                            stu.displayStdInfo();
                        }
                        Console.WriteLine("You entered {0}.", compResponse);
                        break;
                    //list under grad students
                    case "4":
                        compResponse = "List All Under Grad Students";
                        foreach (UnderGradStudent stu in undergradList)
                        {
                            stu.displayStdInfo();
                        }
                        Console.WriteLine("You entered {0}.", compResponse);
                        break;
                    //exits program
                    case "5":
                        continuar = false;
                        break;
                    //catches erros
                    default:
                        Console.WriteLine("Input is not readable.");
                        break;
                }
            }
        }
        //test function to catch errors with long variables
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
        //test function to catch errors with floats
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
