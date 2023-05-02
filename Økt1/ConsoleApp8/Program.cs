namespace ConsoleApp8
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pause til 10.34
            int tall = 0;
            long tall2 = 2030;

            double tall3 = 3.2d;
            float tall4 = 3.3f;
            decimal tall5 = 3.3m;

            string text = "tekst";
            char a = 'a';

            var minText = 2;

            //Console.WriteLine(args[0]);
            //minfunksjon();
            MenuClass.PrintMenu();
            var person = new Person();
            Console.WriteLine(person.Age);
            person.Birthday();
            Console.WriteLine(person.Age);
            Console.WriteLine("Input persons name");
            var name = Console.ReadLine();
            person.SetName(name);
            Console.WriteLine(person.Name);
            //Console.WriteLine("Hello, World!");
            // pause til 11
        }

        static void minfunksjon()
        {
            Console.WriteLine("nå kjører minfunksjon");
        }

        static int minFunksjonReturnererEtTall()
        {
            return 1;
        }
    }
}