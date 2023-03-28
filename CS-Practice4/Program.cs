using CS_Practice4;

namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        /*delegates del = new delegates();
        DoSum addIt = delegates.Sum;
        addIt(2, 3);*/
        //Anonymous anonymous = new Anonymous(); 
        //Lambda lamda = new Lambda(); //in anonymous file

        List <Student> students = new List <Student> ();
        students.Add(new Student() {name="yaswanth",id=8,dept="automobile",age=33});
        students.Add(new Student() { name = "bhupesh", id = 7, dept = "cse", age = 24 });

        foreach(var student in students.OrderBy(x=>x.age))
        {
            Console.WriteLine($"{student.name}");
        }
    }
}