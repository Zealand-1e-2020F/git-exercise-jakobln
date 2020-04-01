using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            myClass minklasse = new myClass("Jakob", "Mariendalsvej 6b", 3600, "Frederikssund");
            myClass klasse2 = new myClass("Peter", "Solvej 15", 3600, "Frederikssund");
            myClass klasse3 = new myClass("Jens", "Roskildevej 13", 3600, "Frederikssund");
            System.Console.WriteLine(minklasse);
            System.Console.WriteLine(klasse2);
            System.Console.WriteLine(klasse3);
        
        }
    }
}
