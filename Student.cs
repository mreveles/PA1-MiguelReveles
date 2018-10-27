using System;

//Start of Base Class
public class Student
{
    string StudName;
    string DateOfBirth;
    long StudID;
    string Major;
    float GPA;

    // public Student(string StdName, string DOB, long ID, string Mjr, float GPA)
    // {
    //     this.StudName = StdName;
    //     this.DateOfBirth = DOB;
    //     this.StudID = ID;
    //     this.Major = Mjr;
    //     this.GPA = GPA;
    // }
    //Base class functions
    public void addStudentInfo()
    {

    }

    public void updateStdInfo()
    {

    }

    public void displayStdInfo()
    {

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

    // public void GradStudent(string prvDegree, string prvUniversity, string undrgdMjr, float undrGPA)

    //subclass functions
    public void addStudentInfo()
    {

    }
    public void updateStdInfo()
    {

    }
    public void displayStdInfo()
    {

    }
}
//End of SubClass GradStudent

//Start of SubClass Under Grad Student
public class UnderGradStudent : Student
{
    enum Classifaction {Freshman, Sophmore, Junior, Senior};
    string previousHSchool;
    Classifaction stdClass;

    //Sub-Class functions
    public void addStudentInfo()
    {

    }
    public void updateStdInfo()
    {

    }
    public void displayStdInfo()
    {

    }
}