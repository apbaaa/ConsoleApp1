using System;
using System.Collections.Generic;
using System.Text;


namespace lab5
{
    public class voids
    {


        public string DtoS(double a)
        {
            if (a < 0)
                throw new ArgumentException("Число должно быть не отрицательным");
            a *= 2.54;
            return (a + " сантиметров");
        }
        public string chetnost(int a)
        {
            a %= 2;
            if (a == 1 | a == -1)
                return "число нечетное";
            else
                return "число четное";

        }


        public string biggestnum(int[] arr)
        {
            if (arr.Length == 0)
                throw new ArgumentException("массив должен быть длиннее нуля");
            int max = 0;
            if (arr != null)
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] > max)
                        max = arr[i];
            string mm = max.ToString();
            return mm;

        }
        public int ost(int a, int b)
        {
            if (b <= 0) throw new ArgumentException("Делитель должен быть >= 0");
            return a % b;
        }
    }
}


