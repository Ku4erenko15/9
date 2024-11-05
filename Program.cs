using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задача 1.
            //    Определить, имеются ли в одномерном массиве случайных чисел элементы,
            //значения которых кратны 11.Вывести такие значения.

            //int[] mass = new int[9] ;
            //Random rnd = new Random() ;
            //for (int i=0; i < mass.Length; i++)
            //{
            //    mass[i] = rnd.Next(1,100);

            //}
            //foreach (int a in mass)
            //{
            //    if(a%11==0)
            //    {
            //        Console.WriteLine(a);
            //    }
            //}

            //Задача 2.
            //    Найти сумму и количество положительных элементов
            //    в одномерном массиве с явной инициализацией.


            //int[] mass = new int[8];
            //int c=0, sum = 0;
            //Random rnd = new Random();
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    mass[i] = rnd.Next(1, 100);
            //}
            //foreach(var elem in mass)
            //{
            //    if(elem>0)
            //    {
            //        sum += elem;
            //        c++;
            //    }
            //}
            //Console.WriteLine($"сумма полож елементов {sum}, их кол-во{c}");


            //Задача 3.
            //    Вывести элементы одномерного массива, 
            //    заполненного с клавиатуры ,в обратном порядке.

            int[] mass = new int[8];
            for(int i=0;i<mass.Length;i++)
            {
                Console.Write($"mass[{i+1}] = ");
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = mass.Length - 1; i >= 0; --i)
                Console.WriteLine(mass[i] );


            Console.ReadLine();
        }
    }
}
