using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genotype
{
    // Класс для вспомогательного функционала
    public static class Utils
    {
        // Метод получения размера любого перечисления
        public static int EnumGetSize<T>() where T : Enum
        {
            T[] values = (T[])Enum.GetValues(typeof(T));
            return values.Length;
        }

        // Метод получения случайного элемента перечисления из переданного диапазона
        public static T EnumGetRandomValue<T>(int range)
        {
            Random random = new();

            // Можно использовать "return (T)random.Next(range);", но это менее безопасный способ приведения типов
            return (T)Enum.ToObject(typeof(T), random.Next(range));
        }

    }

    public static class Extensions
    {
        public static void FillTriangle(this Graphics graphics, Brush brush, Rectangle rectangle)
        {
            Point[] points = new Point[3];

            points[0] = new Point(rectangle.Left, rectangle.Top);
            points[1] = new Point(rectangle.Right, rectangle.Top);
            points[2] = new Point(rectangle.Left + rectangle.Width / 2, rectangle.Bottom);

            graphics.FillPolygon(brush, points);
        }

        public static void DrawTriangle(this Graphics graphics, Pen pen, Rectangle rectangle)
        {
            Point[] points = new Point[3];

            points[0] = new Point(rectangle.Left, rectangle.Top);
            points[1] = new Point(rectangle.Right, rectangle.Top);
            points[2] = new Point(rectangle.Left + rectangle.Width / 2, rectangle.Bottom);

            graphics.DrawPolygon(pen, points);
        }
    }
}
