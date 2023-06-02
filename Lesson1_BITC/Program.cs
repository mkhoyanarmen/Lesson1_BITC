using System;
using System.Text;

namespace Lesson1_BITC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Mutqagreq dzer tariqy: ");
            //byte age = Convert.ToByte(Console.ReadLine());
            byte age = byte.Parse(Console.ReadLine());

            while (!(age > 1 && age < 100))
            {
                Console.WriteLine("Mutqagreq chisht tariq");
                age = byte.Parse(Console.ReadLine());
            }

            if (age >= 18)
            {
                Console.WriteLine("Duq chapahas eq!");
            }
            else
            {
                Console.WriteLine("Duq der chapahas cheq!");
            }
            */
            Console.OutputEncoding = Encoding.UTF8;

            int a = 5; //... 0101
            int b = 2; //... 0010

            int c = a & b; // բիթային "և" (1 & 1 == 1; մ.դ.՝ 0)
            Console.WriteLine("բիթային \"և\": " + c); //... 0000 

            c = a | b; // բիթային "կամ" (0 | 0 == 0; մ.դ.՝ 1)
            Console.WriteLine("բիթային \"կամ\": " + c); //... 0111

            c = a ^ b; // բիթային բացառում ըստ "կամ"-ի (1 ^ 1 == 0; 0 ^ 0 == 0; մ.դ.՝ 1)
            Console.WriteLine("բիթային բացառում ըստ \"կամ\"-ի: " + c); //... 0111

            c = a >> 1; //բիթային շեղում աջ, մեկ բիթ
            Console.WriteLine("բիթային շեղում աջ, մեկ բիթ: " + c); //... 0010

            c = b << 1; //բիթային շեղում ձախ, մեկ բիթ
            Console.WriteLine("բիթային շեղում ձախ, մեկ բիթ: " + c); //... 0100

            c = ~a; //բիթային ժխտում (1 -> 0 && 0 -> 1)
            Console.WriteLine("բիթային ժխտում: " + c); //... 1010
        }
    }
}
