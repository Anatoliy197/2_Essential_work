extern alias L1;

namespace T2
{
    class Program
    {
        static void Main()
        {
            L1.Library.Class1 inst = new L1.Library.Class1();
            inst.Meth();

            System.Console.ReadKey();
        }
    }
}
