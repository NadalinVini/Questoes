using System;

namespace QuestaoUm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = new int[] { 3, 10, 12, 5, 2, 100, 46 };
            int maiorNumero = arrayInt[0];

            for (int i = 0; i < arrayInt.Length; i++)
            {
                if(arrayInt[i] > maiorNumero)
                {
                    maiorNumero = arrayInt[i];
                }
            }
            Console.WriteLine(maiorNumero);
            Console.ReadKey();
        }
    }
}
