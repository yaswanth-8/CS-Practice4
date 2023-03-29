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
        /*
        List <Student> students = new List <Student> ();
        students.Add(new Student() {name="yaswanth",id=8,dept="automobile",age=20});
        students.Add(new Student() { name = "bhupesh", id = 7, dept = "cse", age = -18 });
        students.Add(new Student() { name = "varun", id = 9, dept = "cse", age = 23 });
        students.Add(new Student() { name = "gokul", id = 10, dept = "cse", age = -21 });
        students.Add(new Student() { name = "gokul", id = 10, dept = "cse", age = 9 });
        students.Add(new Student() { name = "gokul", id = 10, dept = "cse", age = 23 });

        students.ForEach(student => student.id += 1);
        students.Sort((s1,s2) => s1.age-s2.age);

        foreach (var student in students)
        {
            Console.WriteLine($"{student.name} {student.age}");
        }*/
        /*
        var result = (int x, int y) =>
        {
            int total = 0;
            total = x + y;
            return total;
        };

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int count = numbers.Count(x=>x%2==0);
        Console.WriteLine(count);*/

        AsyncClass myClass = new AsyncClass();
    }
}