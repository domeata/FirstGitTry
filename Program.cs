using System;

namespace FirstGitTry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");

            Console.WriteLine("Second Change");

            int lenghta = 25;
            int lenghtb = 25;
            int solution = lenghta + lenghtb;

            Console.WriteLine(solution);

            Console.WriteLine("IDK How many changes i made already");

            Console.Clear();

            Console.WriteLine("Geben Sie eine Zahl zu addieren an:");
            double firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben Sie die zweite Zahl ein:");
            double secondnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(firstnumber + secondnumber);

            Console.ReadKey();

            //End of this little programm 
        }
    }
}
