using System;

public class Student
{
    string StudName;
    string DateOfBirth;
    long StudID;
    string Major;
    float GPA;
    public Student(string StdName, string DOB, long ID, string Mjr, float GPA)
    {
        this.StudName = StdName;
        this.DateOfBirth = DOB;
        this.StudID = ID;
        this.Major = Mjr;
        this.GPA = GPA;
    }
    //Base class functions
    public virtual void addStudentInfo()
    {

    }

    public virtual void updateStdInfo()
    {

    }

    public virtual void displayStdInfo()
    {
        // Console.WriteLine("\n\n{0,-20} {1,-10} {2,-10} {3,-10} {4,-10)","Name","Date of Birth","Student ID","Major","GPA");
        // Console.WriteLine("{0,-20} {1,-10} {2,-10} {3,-10} {4,-10}","--------------------","--------","----------","------------" ,"-----");
        Console.WriteLine("{0,-20} {1,-10} {2,-10} {3,-10} {4,-10}", StudName, DateOfBirth, StudID, Major, GPA);
    }
}

// End of Base Class

//Start of Sub-Class Grad Student

public class GradStudent : Student
{
    string previousDegree;
    string previousUniversity;
    string undergradMajor;
    float underGPA;

    public GradStudent(string stdName, string DOB, long ID, string Mjr, float GPA, string prvDegree, string prvUniversity, string undrgdMjr, float undrgdGPA) : base(stdName, DOB, ID, Mjr, GPA)
    {
        this.previousDegree = prvDegree;
        this.previousUniversity = prvUniversity;
        this.undergradMajor = undrgdMjr;
        this.underGPA = undrgdGPA;
    }

    //subclass functions
    public override void addStudentInfo()
    {

    }
    public override void updateStdInfo()
    {

    }
    public override void displayStdInfo()
    {
        base.displayStdInfo();
        // Console.WriteLine("\n\n{0,-20} {1,-10} {2,-10} {3,-10}","Previous Degree","Previous University","Under Grad Major","Under Grad GPA");
        // Console.WriteLine("{0,-20} {1,-10} {2,-10} {3,-10}","--------------------","------------","----------","------------" );
        Console.Write("{0,-10} {1,-10} {2,-10} {3,-10}", previousDegree, previousUniversity, undergradMajor, underGPA);
    }
}
//End of SubClass GradStudent

//Start of SubClass Under Grad Student
public class UnderGradStudent : Student
{
    public enum Classifaction
    {
        Freshman = 1, 
        Sophmore = 2, 
        Junior = 3, 
        Senior=4
    }
    string previousHSchool;
    int stdClass;
    public UnderGradStudent(string stdName, string DOB, long ID, string Mjr, float GPA, string pvsHschool, int stdClass) : base(stdName, DOB, ID, Mjr, GPA)
    {
        this.previousHSchool = pvsHschool;
        this.stdClass = stdClass;
        
    }
    //Sub-Class functions
    public override void addStudentInfo()
    {

    }
    public override void updateStdInfo()
    {

    }
    public override void displayStdInfo()
    {
        base.displayStdInfo();
        Console.Write("{0,-10} {1,-10}", previousHSchool, Enum.GetName(typeof(Classifaction),stdClass));

    }
}
