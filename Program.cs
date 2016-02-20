using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int size = 0, k = 0, tmp = 0;
                double a = 0, b = 0, max = 0, sum = 0, tmp1 = 0;
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Введите размерность массива: ");
                size = int.Parse(Console.ReadLine());
                double[] arr = new double[size];
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Введите {0}-й элемент массива : ", (i + 1));
                    arr[i] = Convert.ToDouble(Console.ReadLine());
                }
                Console.Write("Ваш массив: ");
                for (int i = 0; i < size; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
                //-------------------------------------------------------------------------------------
                max = arr[0];
                for (int i = 1; i < size; i++)
                {
                    if (Math.Abs(arr[i]) > Math.Abs(max))
                    {
                        max = arr[i];
                    }
                }
                Console.WriteLine("Максимальный по модулю элемент: " + max);
                //------------------------------------------------------------------------------------------
                for (int i = 0; i < size; i++)
                {
                    if (arr[i] > 0)
                    {
                        tmp++;
                    }
                    k = i;
                    if (tmp == 1) break;
                }
                if (tmp == 1)
                {
                    if ((k != size - 1) && (k != size - 2))
                    {
                        for (int i = k + 1; i < size; i++)
                        {
                            sum += arr[i];
                        }
                        Console.WriteLine("Сумма элементов после первого положительного: " + sum);
                    }
                    else if (k == size - 2)
                    {
                        Console.WriteLine("Сумму элемнтов посчитать невозможно, потому что первый положительный элемент - предпоследний!");
                    }
                    else
                    {
                        Console.WriteLine("После первого положительного элемента нет элементов!");
                    }
                }
                else
                {
                    Console.Write("Cумму после первого положительного элемента вычислить невозможно, так как его - нет\n");
                }
                //-----------------------------------------------------------------------------------
                Console.WriteLine("Введите а - начало промежутка: ");
                a = Convert.ToDouble(Console.ReadLine()); ;
                Console.WriteLine("Введите b - конец промежутка: ");
                b = Convert.ToDouble(Console.ReadLine()); ;
                if (a >= b)
                {
                    Console.WriteLine("Начало промежутка не может быть больше или быть равным концу промежутка!!!!!");
                }
                else
                {
                    for (int j = 0; j < size; j++)
                    {
                        for (int i = 1; i < size; i++)
                        {
                            if (((int)arr[i] >= a && (int)arr[i] <= b) && ((int)arr[i - 1] < a || (int)arr[i - 1] > b))
                            {
                                tmp1 = arr[i];
                                arr[i] = arr[i - 1];
                                arr[i - 1] = tmp1;
                            }
                        }
                    }
                    Console.WriteLine("Отсортированный массив: ");
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
                //-------------------------------------------------------------------------------------
                Console.WriteLine("Igor");
		Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("UNEXPECTED ERROR(CODE:225)!!!!!");
                Console.ReadKey();
            }
        }
    }
}
