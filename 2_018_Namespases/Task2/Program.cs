extern alias L1;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            L1.ClassLibrary1.Class1 inst = new L1.ClassLibrary1.Class1();
            inst.Meth();

            System.Console.ReadKey();
        }
    }
}
