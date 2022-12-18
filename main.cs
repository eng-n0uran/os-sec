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
    public string _name1;
    public int _age1;

    public person(int age, string name)
    {
        _name1=name;
        _age1=age;
    }
    public void SetName(string name)
    {
        if(string.IsNullOrEmpty(Name))      
        {
            throw new Exception("Name cannot be null or empty");
        }
        _name1 = name;
    }
    public string GetName()
    {
        if(string.IsNullOrEmpty(_name1))   
        {
            return "no Name";
        }
        else
        {
            return _name1;
        }
    }
    public void SetAge(int age){
        if(age<=0||age>100)
        {
            throw new Exception("not accepted age");
        }
        _age1=age
    public int GetAge();
           return _age1;
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
    private int _year1;
    private double _gpa1;
    public Student (string _name1,int _age1,int _year1,double _gpa1 ):base(_name1,_age1){
        if(gpa1<0||gpa1>4){
            throw new Exception("not accepted gpa");
        }
         if(year<1||year>5){
            throw new Exception("not accepted year");
        }
        
        _year1=year;
        _gpa1=gpa;
    }
    public double GetGpa(); return _gpa1;
    public int GetYear() ; return _year1;
    
    public void SetGpa(double _gpa1){
        if(_gpa1<0||_gpa1>4){
            throw new Exception("not accepted gpa");
        }
        _gpa1=gpa;
    }
    public void SetYear(int _year1){
        if(_year1<1||_year1>5){
            throw new Exception("not accepted year");
        }
        _year1=year;
    }
    public override void Print(){
        Console.WriteLine($"my name is {GetName()}, my age is {GetAge()}, and gpa is {GetGpa()}");
    }
}
  Public class staff :person{
      private int _joinYear1;
    private double _salary1;
    public staff (string _name1,int _age1,double _salary1 ,int _joinyear1):base(_name1,_age1){
        if(salary<0||salary>120000){
            throw new Exception("not accepted salary");
        }
        int diffrence=_joinyear1-_age1;
        if(diffrence<=22){
            throw new Exception("not accepted year");
        }
    _salary1=salary;
    _joinYear1=joinyear;
    }
    public double GetSalary() ;return _salary1;
    public void SetSalary(double _salary1){
        if(_salary1<0 || _salary1>120000){
            throw new Exception("not salary");
        }
        _salary1=salary;
    }
    public int GetJoinYear();return _year1;
    public void SetJoinYear(int _joinyear1){
        int differance=GetJoinYear()-GetAge();
        if(differance<=22){
            throw new Exception("no join year");
        }
        _joinYear1=joinyear;
    }  public override void Print(){
            Console.WriteLine($"my name is {GetName()}, my age is {GetAge()}, and my salary is {GetSalary()}");
        }
}public  class program{
    private static void Main(){
    Console.WriteLine("put a number : 1 for student, 2 for staff, 3 for normal person ,4 for print all peaple );
    int n=1;
    var database=new Database();
    while (n!=0)
    {
        Console.Write("the option is: ");
        n=Convert.ToInt32(Console.ReadLine());
        switch (n)
    {
        case 1:
        Console.Write("the Name: ");
        var _name1=Console.ReadLine();
        Console.Write("the Age: ");
        var _age1 =Convert.ToInt32(Console.ReadLine());
        Console.Write("the Year: ");
        var _year1 =Convert.ToInt32(Console.ReadLine());
        Console.Write("the Gpa: ");
        var _gpa1 = Convert.ToSingle(Console.ReadLine());
        break;
                
        case 2:
        Console.Write("the Name: ");
        _name1=Console.ReadLine();
        Console.Write("the Age: ");
        _age1 =Convert.ToInt32(Console.ReadLine());
        Console.Write("the Salary: ");
        var _salary1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("the JoinYear: ");
        var _joinyear1 = Convert.ToInt32(Console.ReadLine());
        break;
        case 3:
        Console.Write("the Name: ");
        _name1=Console.ReadLine();
        Console.Write("the Age: ");
        _age1 =Convert.ToInt32(Console.ReadLine());
        
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
