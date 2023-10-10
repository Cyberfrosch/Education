using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    // Класс для вспомогательного функционала
    public static class EnumUtilities
    {
        // Метод получения размера любого перечисления
        public static int GetSize<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T)).Length;
        }

        // Метод получения случайного элемента перечисления из переданного диапазона
        public static T GetRandomValue<T>(int range) where T : Enum
        {
            Random random = new();

            // Можно использовать "return (T)random.Next(range);", но это менее безопасный способ приведения типов
            if (range > GetSize<T>())
            {
                return (T)Enum.ToObject(typeof(T), GetSize<T>());
            }
            else
            {
                return (T)Enum.ToObject(typeof(T), random.Next(range));
            }
        }

        // Метод получения случайного элемента перечисления из диапазона размера перечисления
        public static T GetRandomValue<T>() where T : Enum
        {
            return GetRandomValue<T>(GetSize<T>());
        }
    }
}
