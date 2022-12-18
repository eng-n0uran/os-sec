/*using System;
namespace Y {
class Program {
static void Main(string[] args) {
const double pi = 3.14159;
double r;
Console.WriteLine("Enter Radius: ");
r = Convert.ToDouble(Console.ReadLine());
double areaCircle = pi * r * r;
Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
Console.ReadLine();
}
}
}*/
public class person
{
    public string name1;
    public int age1;

    public person(int age, string name)
    {
        name1=name;
        age1=age;
    }
    public void SetName(string name)
    {
        if(string.IsNullOrEmpty(Name))      
        {
            throw new Exception("Name cannot be null or empty");
        }
        name1 = name;
    }
    public string GetName()
    {
        if(string.IsNullOrEmpty(name1))   
        {
            return "no Name";
        }
        else
        {
            return name1;
        }
    }
    public void SetAge(int age){
        if(age<=0||age>100)
        {
            throw new Exception("not accepted age");
        }
        age1=age
    public int GetAge();
           return age1;
 public static void print()
 {
        Console.WriteLine($"my name is {GetName()}, my age is {GetAge()}");
    }
}
public class Database{
    public person[] people=new person[60];
    private int cIndex=0;
    public void AddStudent(Student student){
        people[cIndex++]=student;
    }
    public void AddStaff(Staff staff){
        people[cIndex++]=staff;
    }
    public void AddPerson(Person person){
        people[cIndex++]=person;
    }
    public void PrintAll(){
        for(int i=0;i<cIndex;i++){
        People[i].Print();
        }
    }
}
public class Student :person{
    private int year1;
    private double gpa1;
    public Student (string name1,int age1,int year1,double gpa1 ):base(name1,age1){
        if(gpa1<0||gpa1>4){
            throw new Exception("not accepted gpa");
        }
         if(year<1||year>5){
            throw new Exception("not accepted year");
        }
        
        year1=year;
        gpa1=gpa;
    }
    public double GetGpa(); return gpa1;
    public int GetYear() ; return year1;
    
    public void SetGpa(double gpa1){
        if(gpa1<0||gpa1>4){
            throw new Exception("not accepted gpa");
        }
        gpa1=gpa;
    }
    public void SetYear(int year1){
        if(year1<1||year1>5){
            throw new Exception("not accepted year");
        }
        year1=year;
    }
    public override void Print(){
        Console.WriteLine($"my name is {GetName()}, my age is {GetAge()}, and gpa is {GetGpa()}");
    }
}
  Public class staff :person{
      private int joinYear1;
    private double salary1;
    public staff (string name1,int age1,double salary1 ,int joinyear1):base(name1,age1){
        if(salary<0||salary>120000){
            throw new Exception("not accepted salary");
        }
        int diffrence=joinyear1-age1;
        if(diffrence<=22){
            throw new Exception("not accepted year");
        }
    salary1=salary;
    joinYear1=joinyear;
    }
    public double GetSalary() ;return salary1;
    public void SetSalary(double salary1){
        if(salary1<0 || salary1>120000){
            throw new Exception("no salary");
        }
        salary1=salary;
    }
    public int GetJoinYear();return year1;
    public void SetJoinYear(int joinyear1){
        int differance=GetJoinYear()-GetAge();
        if(differance<=22){
            throw new Exception("no join year");
        }
        joinYear1=joinyear;
    }  public override void Print(){
            Console.WriteLine($"my name is {GetName()}, my age is {GetAge()}, and my salary is {GetSalary()}");
        }
}public  class program{
    private static void Main(){
    Console.WriteLine("enter a number 1)student 2)staff 3)print all peaple 4)person \"not a student and not a staff\"");
    int x=1;
    var database=new Database();
    while (x!=0)
    {
        Console.Write("Option: ");
        x=Convert.ToInt32(Console.ReadLine());
        switch (x)
    {
        case 1:
        Console.Write("Name: ");
        var name=Console.ReadLine();
        Console.Write("Age: ");
        var age =Convert.ToInt32(Console.ReadLine());
        Console.Write("Year: ");
        var year =Convert.ToInt32(Console.ReadLine());
        Console.Write("Gpa: ");
        var gpa = Convert.ToSingle(Console.ReadLine());
        break;
                
        case 2:
        Console.Write("Name: ");
        name1=Console.ReadLine();
        Console.Write("Age: ");
        age1 =Convert.ToInt32(Console.ReadLine());
        Console.Write("Salary: ");
        var salary1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("JoinYear: ");
        var joinyear1 = Convert.ToInt32(Console.ReadLine());
        break;
        case 3:
        Console.Write("Name: ");
        name1=Console.ReadLine();
        Console.Write("Age: ");
        age1 =Convert.ToInt32(Console.ReadLine());
        
        break;
        case 4:
            database.PrintAll();
        break;
        default:
        return;
    }
    }

}
}
