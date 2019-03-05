using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteProceduresFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            int result = a * b;

            Console.WriteLine(result);


            a = 7;
            b = 8;

            result = a * b;

            Console.WriteLine(result);


            a = 0;
            b = 1;

            result = a * b;

            Console.WriteLine(result);

            int rer = 0;

            CalculerMultiplication(2, 5, ref rer);
            CalculerAddition(2, 5, out rer);

            rer = CalculerDivision(2, 5);

            if(DivisionDeChaines(Console.ReadLine(), Console.ReadLine(), out rer))
            {
                Console.WriteLine(rer);
            }

            Console.WriteLine(rer);
        }

        static void CalculerMultiplication(int un, int deux, ref int result)
        {
            int a = un;
            int b = deux;

            //result = a * b;
        }

        static void CalculerAddition(int un, int deux, out int result)
        {
            int a = un;
            int b = deux;

            result = a + b;
        }

        static int CalculerDivision(int un, int deux)
        {
            int a = un;
            int b = deux;

            return a / b;
        }

        static bool DivisionDeChaines(string val1, string val2, out int val3)
        {
            int val1entier = 0;
            bool isOK = int.TryParse(val1, out val1entier);

            int val2entier = 0;
            isOK = isOK && int.TryParse(val2, out val2entier);

            val3 = val1entier / val2entier;

            return isOK;
        }
    }
}
