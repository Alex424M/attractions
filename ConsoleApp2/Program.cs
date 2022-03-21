using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int DeltaTime = 12;
            int MaxTime = 32;
            double SumTime = 0;
            int MaxImportance = 0;
            object[] temp = new object[5];
            List<List<object>> list = new List<List<object>>();
            object[,] mass = new object[20, 5]
            {
                {"Исаакиевский собор",5,10,0,0},
                {"Эрмитаж",8,11,0,0},
                {"Кунсткамера",3.5,4,0,0},
                {"Петропавловская крепость",10,7,0,0},
                {"Ленинградский зоопарк",9,15,0,0},
                {"Медный всадник",1,17,0,0},
                {"Казанский собор",4,3,0,0},
                {"Спас на Крови",2,9,0,0},
                {"Зимний дворец Петра I",7,12,0,0},
                {"Зоологический музей",5.5,6,0,0},
                {"Музей обороны и блокады Ленинграда",2,19,0,0},
                {"Русский музей",5,8,0,0},
                {"Навестить друзей",12,20,0,0},
                {"Музей восковых фигур",2,13,0,0},
                {"Литературно-мемориальный музей Ф.М. Достоевского",4,2,0,0},
                {"Екатерининский дворец",1.5,5,0,0},
                {"Петербургский музей кукол",1,14,0,0},
                {"Музей микроминиатюры «Русский Левша»",3,18,0,0},
                {"Всероссийский музей А.С. Пушкина и филиалы",6,1,0,0},
                {"Музей современного искусства Эрарта",7,16,0,0}
            };

            for (int i = 0; i < 20; i++)
            {
                mass[i, 3] = DeltaTime - Convert.ToDouble(mass[i, 1]);
                mass[i, 4] = Convert.ToDouble(mass[i, 2]) * Convert.ToDouble(mass[i, 3]);
            }
            for (int i = 0; i < 20 - 1; i++)
            {
                for (int j = i + 1; j < 20; j++)
                {
                    if (Convert.ToDouble(mass[i, 4]) < Convert.ToDouble(mass[j, 4]))
                    {
                        temp[0] = mass[i, 0]; temp[1] = mass[i, 1]; temp[2] = mass[i, 2]; temp[3] = mass[i, 3]; temp[4] = mass[i, 4];
                        mass[i, 0] = mass[j, 0]; mass[i, 1] = mass[j, 1]; mass[i, 2] = mass[j, 2]; mass[i, 3] = mass[j, 3]; mass[i, 4] = mass[j, 4];

                        mass[j, 0] = temp[0]; mass[j, 1] = temp[1]; mass[j, 2] = temp[2]; mass[j, 3] = temp[3]; mass[j, 4] = temp[4];
                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                if (Convert.ToDouble(mass[i, 1]) + SumTime <= MaxTime)
                {
                    SumTime += Convert.ToDouble(mass[i, 1]);
                    MaxImportance += Convert.ToInt32(mass[i, 2]);
                    var user = new List<object> {mass[i,0], mass[i, 1], mass[i, 2]};
                    list.Add(user);
                }
            }


            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(list[i][j]+" ");
                }
                Console.WriteLine();
            }
            Console.Write($"Время: {SumTime}, сумма важности: {MaxImportance}");
            Console.ReadKey();
        }

    }

}
