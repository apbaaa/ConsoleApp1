using System;

namespace lab5
{
    class Program
    {

        static void Main(string[] args)
        {
            voids func = new voids();
            Console.WriteLine("Выполняемые функции:\n1)перевести дюймы в сантиметры\n2)Проверить число на четность(только целочисленные)\n3)Выбрать наибольшее число из массива целых чисел\n4)найти остаток от деления\n");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("Введите число");
                    try
                    {
                        string a = func.DtoS(double.Parse(Console.ReadLine()));
                        Console.WriteLine(a);
                    }
                    catch
                    {
                        Console.WriteLine("Что-то пошло не так");
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите число");
                    try
                    {
                        string b = func.chetnost(int.Parse(Console.ReadLine()));
                        Console.WriteLine(b);
                    }
                    catch
                    {
                        Console.WriteLine("Что-то пошло не так");
                    }
                    break;
                case 3:
                    try
                    {
                        int col = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите числа:");
                        int[] arr = new int[col];
                        for (i = 0; i < col; i++)
                            arr[i] = int.Parse(Console.ReadLine());
                        string big_chislo = func.biggestnum(arr);
                        Console.WriteLine("самое большое число:" + big_chislo);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Введите первое число");
                        int res1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        int res2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Остаток: " + func.ost(res1, res2));
                    }
                    catch
                    {
                        Console.WriteLine("Что-то пошло не так");
                    }
                    break;
            }
        }
    }
}
