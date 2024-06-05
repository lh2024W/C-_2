using System.ComponentModel.DataAnnotations;

namespace C__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количествло ступеней: ");
            int length=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели число: ", length);
            string s = " ";
            
            for (int i = 0; i < length; i++)
            {
                s += "  ";
                Console.WriteLine("***");
                Console.Write(s);
                for (int j = 0; j < 1; j++) 
                {
                    Console.WriteLine("*");
                }
                Console.Write(s);
            }
        }
    }
}
