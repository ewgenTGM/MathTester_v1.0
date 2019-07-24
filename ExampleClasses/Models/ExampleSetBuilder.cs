using System;
using System.Collections.Generic;

namespace ExampleClasses.Models
{
    public static class ExtentionMethods
    {
        public static Queue<T> ToQueue<T>(this List<T> self)
        {
            Queue<T> queue = new Queue<T>();
            foreach (var item in self)
            {
                queue.Enqueue(item);
            }
            return queue;
        }
    }
    /// <summary>
    /// Заводик по производству примеров
    /// </summary>
    public class ExampleSetBuilder
    {
        private List<IExample> ExampleSet = new List<IExample>();

        public enum ExampleType
        {
            Random = 1,
            Multiply = 2,
            Summ = 3,
            Divide = 4
        }

        /// <summary>
        /// Метод, возвращает коллекцию (список) примеров
        /// </summary>
        /// <returns>Queue<IExample></returns>
        public Queue<IExample> GetExampleSet()
        {
            if (ExampleSet.Count == 0)
            {
                throw new Exception("Список примеров пуст!");
            }
            return ExampleSet.ToQueue();
        }
        /// <summary>
        /// Метод, добавляет примеры в очередь
        /// </summary>
        /// <param name="count">Количество примеров, которое будет добавлено</param>
        /// <param name="exampleType">Тип добавляемых примеров</param>
        public void AddExampleToSet(int count, ExampleType exampleType)
        {
            if (count < 1)
            {
                throw new ArgumentException("Количество примеров должно быть больше 0");
            }

            switch (exampleType)
            {
                case ExampleType.Random:
                    GenerateRandomExamples(count);
                    break;

                case ExampleType.Multiply:
                    for (int i = 0; i < count; i++)
                    {
                        ExampleSet.Add(new MultiplyExample());
                    }
                    break;

                case ExampleType.Summ:
                    for (int i = 0; i < count; i++)
                    {
                        ExampleSet.Add(new SummExample());
                    }
                    break;

                case ExampleType.Divide:
                    for (int i = 0; i < count; i++)
                    {
                        ExampleSet.Add(new DivideExample());
                    }
                    break;
            }
        }

        /// <summary>
        /// Метод, генерирует случайные примеры
        /// </summary>
        /// <param name="count">Количество примеров</param>
        private void GenerateRandomExamples(int count)
        {
            if (count < 1)
            {
                throw new ArgumentException("Количество примеров должно быть больше 0");
            }
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                switch (r.Next(1, 4))
                {
                    case 1:
                        ExampleSet.Add(new DivideExample());
                        break;

                    case 2:
                        ExampleSet.Add(new SummExample());
                        break;

                    case 3:
                        ExampleSet.Add(new MultiplyExample());
                        break;
                }
            }
        }
        
        /// <summary>
        /// Метод, перемешивает коллекцию
        /// </summary>
        /// <param name="times">Количество перемешиваний</param>
        public void ShakeExampleSet(int times = 1)
        {
            if (times < 1)
            {
                throw new ArgumentException("Количество перемешиваний должно быть больше 0");
            }
            Random r = new Random();
            for (int k = 0; k < times; k++)
            {
                for (int i = ExampleSet.Count - 1; i >= 1; i--)
                {
                    int j = r.Next(i + 1);

                    var temp = ExampleSet[j];
                    ExampleSet[j] = ExampleSet[i];
                    ExampleSet[i] = temp;
                }
            }
        }
    }
}