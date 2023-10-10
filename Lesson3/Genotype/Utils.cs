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
            return Enum.GetValues(typeof(T)).Length;
        }

        // Метод получения случайного элемента перечисления из переданного диапазона
        public static T EnumGetRandomValue<T>(int range) where T : Enum
        {
            Random random = new();

            // Можно использовать "return (T)random.Next(range);", но это менее безопасный способ приведения типов
            if (range > EnumGetSize<T>())
            {
                return (T)Enum.ToObject(typeof(T), EnumGetSize<T>());
            }
            else
            {
                return (T)Enum.ToObject(typeof(T), random.Next(range));
            }
        }

        // Метод получения случайного элемента перечисления из диапазона размера перечисления
        public static T EnumGetRandomValue<T>() where T : Enum
        {
            return EnumGetRandomValue<T>(EnumGetSize<T>());
        }
    }
}
