using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSearches
{
    /// От Вас требуется написать функцию bsearch, 
    /// которая принимает на вход отсортированный по убыванию массив целых чисел и целое число X.
    /// В качестве результата функция должна возвращать индекс первого элемента массива, 
    /// строго меньшего X. 
    /// В Вашей реализации функция может принимать любое количество любых параметров, 
    /// только 2 этих параметра обязательны.  
    /// 
    /// Комментарий автора... Я надеюсь вы не собираетесь вгонять массив 2147483647 различных чисел, и чисел не вписывающихся -2147483648 : 2147483647
    /// В задании не было про то, что я должен обработать все исключительные ситуации... По крайне мере StackOverflow...
    /// 

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 10, 10, 10, 9, 8, 7, 7, 6, 5, 4, 3, 2, 1, 1, 1, 0, -1, -2, -3, -5, -9 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{ array[i],5}");
            }
            Console.WriteLine(Environment.NewLine);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i,5}");
            }
            Console.WriteLine(Environment.NewLine);
            for (int x = -8; x <= 10; x++)
            {
                if (CheckArray(array, x))
                {
                    Console.WriteLine($"При x = {x} <Index = {BSearchCircle(array, x)}");
                }
            }
            Console.ReadKey();
        }


        private static bool CheckArray(int[] array, int x)
        {
            if (array.Length == 0)
            {
                throw new Exception("Массив пуст, смысла нету");
            }
            if (array[0] < x || array[array.Length - 1] >= x)
            {
                throw new Exception("Число не входит в область массива, или является его крайнем минимальным пределом");
            }
            return true;
        }

        public static int BSearchCircle(int[] array, int x)
        {
            // Приступить к поиску.
            // Номер первого элемента в массиве.
            int first = 0;
            // Номер элемента массива, СЛЕДУЮЩЕГО за последним
            int last = array.Length;
            //Console.WriteLine("F:{0}, L:{1}", first, last);
            while (first < last)
            {
                int mid = first + (last - first) / 2;
                //Console.WriteLine("M:"+mid);
                if (x > array[mid])
                    last = mid;
                else
                    first = mid + 1;
                //Console.WriteLine("F:{0}, L:{1}", first, last);
            }
            return last;
        }

    }
}