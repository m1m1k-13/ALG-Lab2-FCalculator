using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2
{
    public abstract class MathLib
    {
        public const decimal E = 2.7182818284590452354m;

        public const decimal PI = 3.14159265358979323846m;

        /// <summary>
        /// Модуль числа
        /// </summary>
        /// <param name="x">Аргумент</param>
        /// <returns></returns>
        public static decimal Abs(decimal x)
        {
            if (x < 0) x = -x;
            return x;
        }

        /// <summary>
        /// Вычисление показательной функции
        /// </summary>
        /// <param name="x">Значение аргумента</param>
        /// <param name="eps">Погрешность</param>
        /// <returns>Значение функции</returns>
        public static decimal Ex(decimal x, decimal eps)
        {
            decimal u = 1;
            decimal S = u;

            for (int n = 1; Abs(u) >= eps; n++)
            {
                u *= x / n;
                S += u;
            }

            return S;
        }

        /// <summary>
        /// Вычисление квадратного корня
        /// </summary>
        /// <param name="x">Значение аргумента</param>
        /// <param name="eps">Погрешность</param>
        /// <returns>Значение функции</returns>
        /// <exception cref="ArgumentException"></exception>
        public static decimal Sqrt(decimal x, decimal eps)
        {
            if (x < 0) throw new ArgumentException("Неверный ввод");

            if (x == 0)
            {
                return 0;
            }

            decimal x0, x1 = x / 2;
            do
            {
                x0 = x1;
                x1 = 0.5m * (x0 + x / x0);
            }
            while (Abs(x1 - x0) >= eps);

            return x1;
        }

        /// <summary>
        /// Вычисление натурального логарифма
        /// </summary>
        /// <param name="z">Значение аргумента</param>
        /// <param name="eps">Погрешность</param>
        /// <returns>Значение функции</returns>
        /// <exception cref="ArgumentException"></exception>
        public static decimal Ln(decimal z, decimal eps)
        {
            if (z <= 0) throw new ArgumentException("Неверный ввод");

            if (z == 1) return 0;

            decimal u0 = (1 - z) / (1 + z);
            decimal u = u0;
            decimal S = u0;
            int k = 1;

            while (Abs(u) >= eps)
            {
                k += 2;
                u = u * u0 * u0;
                S += u / k;
            }

            return -2 * S;
        }

        /// <summary>
        /// Вычисление десятичного логарифма
        /// </summary>
        /// <param name="z">Значение аргумента</param>
        /// <param name="eps">Погрешность</param>
        /// <returns>Значение функции</returns>
        /// <exception cref="ArgumentException"></exception>
        public static decimal Lg(decimal x, decimal eps)
        {
            if (x <= 0) throw new ArgumentException("Неверный ввод");

            decimal lnX = Ln(x, eps);
            decimal ln10 = Ln(10, eps);

            return lnX / ln10;
        }

        /// <summary>
        /// Перевод градусов в радианы
        /// </summary>
        /// <returns></returns>
        private static decimal GetAngleInRadians(decimal x)
        {
            return x * PI / 180m;
        }

        /// <summary>
        /// Вычисление синуса
        /// </summary>
        /// <param name="z">Значение аргумента</param>
        /// <param name="eps">Погрешность</param>
        /// <returns>Значение функции</returns>
        public static decimal Sin(decimal x, decimal eps, bool radians)
        {
            if (!radians) x = GetAngleInRadians(x);

            x %= 2 * PI;

            decimal u = x;
            decimal S = u;

            for (int n = 1; Abs(u) >= eps; n++)
            {
                u = -(x * x * u / (2 * n * (2 * n + 1)));
                S += u;
            }

            return S;
        }

        /// <summary>
        /// Вычисление косинуса
        /// </summary>
        /// <param name="z">Значение аргумента</param>
        /// <param name="eps">Погрешность</param>
        /// <returns>Значение функции</returns>
        public static decimal Cos(decimal x, decimal eps, bool radians)
        {
            if (!radians) x = GetAngleInRadians(x);

            x %= 2 * PI;

            decimal u = 1;
            decimal S = u;

            for (int n = 1; Abs(u) >= eps; n++)
            {
                u = -(x * x * u / (2 * n * (2 * n - 1)));
                S += u;
            }

            return S;
        }

        /// <summary>
        /// Вычисление тангенса
        /// </summary>
        /// <param name="z">Значение аргумента</param>
        /// <param name="eps">Погрешность</param>
        /// <returns>Значение функции</returns>
        public static decimal Tg(decimal x, decimal eps, bool radians)
        {
            if (!radians) x = GetAngleInRadians(x);

            x %= 2 * PI;

            decimal cosX = MathLib.Cos(x, eps, true);

            if (Abs(cosX) <= eps) throw new ArgumentException("Не существует");

            decimal sinX = MathLib.Sin(x, eps, true);

            return sinX / cosX;
        }

        /// <summary>
        /// Вычисление котангенса
        /// </summary>
        /// <param name="z">Значение аргумента</param>
        /// <param name="eps">Погрешность</param>
        /// <returns>Значение функции</returns>
        public static decimal Ctg(decimal x, decimal eps, bool radians)
        {
            if (!radians) x = GetAngleInRadians(x);

            x %= 2 * PI;

            decimal sinX = MathLib.Sin(x, eps, true);

            if (Abs(sinX) <= eps) throw new ArgumentException("Не существует");

            decimal cosX = MathLib.Cos(x, eps, true);

            return cosX / sinX;
        }
    }
}
