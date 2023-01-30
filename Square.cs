using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator
{
    public class Square
    {
        public double CountSquare(double r) // Вычисление площади круга
        {
            double S;
            S = Math.PI * Math.Pow(r, 2);
            return S;
        }

        public double CountSquare(double a, double b, double c) // Вычисление площади любого треугольника по трем сторонам
        {
            double S;
            if (IsTriangleExist(a, b, c))
            {
                double p;
                p = (a + b + c) / 2;
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
                S = 0;
            return S;
        }

        public bool IsTriangleExist(double a, double b, double c) // Проверка существования треугольника
        {
            bool triangleExist;
            if (a > 0 && b > 0 && c > 0 &&
                a < b + c &&
                b < a + c &&
                c < b + a)
                triangleExist = true;
            else
                triangleExist = false;
            return triangleExist;
        }
        public bool IsTriangleRight(double a, double b, double c) // Проверка прямоугольности треугольника
        {
            bool triangleRight;
            double hypot, legSum = 0d;
            double[] sides = { a, b, c };
            hypot = sides.Max();
            for (int i = 0; i < sides.Length; i++)
            {
                if (sides[i] != hypot)
                {
                    legSum += Math.Pow(sides[i], 2);
                }
            }
            if (legSum == Math.Pow(hypot, 2))
                triangleRight = true;
            else
                triangleRight = false;
            return triangleRight;
        }

        public enum ChooseShape
        {
            Triangle, Round
        }
    }
}
