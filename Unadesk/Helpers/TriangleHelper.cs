using System;
using Unadesk.Model;

namespace Unadesk.Helpers
{
    public static class TriangleHelper
    {
        public static void CheckTriangleType (Triangle triangle)
        {
            var legsSquare = triangle.legA * triangle.legA + triangle.legB * triangle.legB;
            var hipotenuseSquare = triangle.hypotenuse * triangle.hypotenuse;

            if (hipotenuseSquare > legsSquare)
            {
                Console.WriteLine("Треугольник тупоугольный");
            }
            else if (hipotenuseSquare == legsSquare)
            {
                Console.WriteLine("Треугольник прямой");
            }
            else
            {
                Console.WriteLine("Треугольник острый");
            }


        }

        /// <summary>
        /// Метод запрашивает у пользователя стороны треугольника.
        /// </summary>
        /// <param name="checkTrianleCanExists"> Проверять ли треугольник на возможность сущестования.</param>
        /// <returns></returns>
        public static Triangle GetTriangle(bool checkTrianleCanExists)
        {
            string[] nums;
            int[] triangleLegs = new int[3];
            string repeatString = $"Необходимо ввести значения заново.{Environment.NewLine}Нажмите любую клавишу чтобы продолжить...";

            do
            {
                int n = 0;
                bool allOK = true;

                Console.Clear();
                Console.Write("Введите стороны треугольника: ");
                var userInput = Console.ReadLine().Split();

                foreach (var strNum in userInput)
                {
                    if (int.TryParse(strNum, out var num))
                    {
                        triangleLegs[n++] = num;
                    }
                    else
                    {
                        Console.Write($"Введенное значение \"{strNum}\" не является числом. {repeatString}");
                        Console.ReadKey();
                        allOK = false;
                        break;
                    }
                }

                if (!allOK)
                    continue;

                //Array.Sort(triangleLegs);
                var triangle =  new Triangle(triangleLegs[0], triangleLegs[1], triangleLegs[2]);

                if (checkTrianleCanExists && !CheckTriangleCanExists(triangle))
                {
                    Console.WriteLine($"Треугольник с такими сторонами не может существовать. {repeatString}");
                    Console.ReadKey();
                    continue;
                }

                return triangle;
            } while (true);
        }

        /// <summary>
        /// Метод проверяет треугольник на возможность существаования
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        private static bool CheckTriangleCanExists(Triangle triangle)
        {
            if (triangle.legA + triangle.legB > triangle.hypotenuse
                && triangle.legA + triangle.hypotenuse > triangle.legB
                && triangle.legB + triangle.hypotenuse > triangle.legA)
                return true;

            return false;
        }
    }
}
