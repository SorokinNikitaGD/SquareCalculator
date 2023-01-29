using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator
{
    public class Square
    {
        bool triangleExist, triangleRight;
        public void CountSquare(double a, double b, double c, out double S) // Вычисление площади любого треугольника по трем сторонам
        {
            IsTriangleExist(a, b, c);
            if (triangleExist)
            {
                IsTriangleRight(a, b, c, out S);
                if (!triangleRight)
                {
                    double p;
                    p = (a + b + c) / 2;
                    S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                }
            }
            else
                S = 0;
        }
        private void CountSquare(double r, out double S) // Вычисление площади круга
        {
            S = Math.PI * Math.Pow(r, 2);
        }

        private void IsTriangleExist(double a, double b, double c) // Проверка существования треугольника
        {
            if (a > 0 && b > 0 && c > 0 &&
                a < b + c &&
                b < a + c &&
                c < b + a)
                triangleExist = true;
            else
                triangleExist = false;
        }
        private void IsTriangleRight(double a, double b, double c, out double Square) // Проверка прямоугольности треугольника
        {
            double hypot, legSum = 0d;
            double[] sides = { a, b, c };
            hypot = sides.Max();
            Square = 1;
            for (int i = 0; i < sides.Length; i++)
            {
                if (sides[i] != hypot)
                {
                    legSum += Math.Pow(sides[i], 2);
                    Square *= sides[i];
                }
            }
            if (legSum == Math.Pow(hypot, 2))
                triangleRight = true;
            else
                triangleRight = false;
            Square /= 2;
        }

        public enum ChooseShape
        {
            Triangle, Round
        }
    }
}
