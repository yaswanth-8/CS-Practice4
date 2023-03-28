using CS_Practice4;

namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        delegates del = new delegates();
        DoSum addIt = delegates.Sum;
        addIt(2, 3);
    }
}