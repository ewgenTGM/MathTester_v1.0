using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleClasses.Models;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleSetBuilder exampleSetBuilder = new ExampleSetBuilder();
            exampleSetBuilder.AddExampleToSet(5, ExampleSetBuilder.ExampleType.Random);
            Training training = new Training(exampleSetBuilder, 3);
            training.TrainingStarted += (sender, dateTime) => Console.WriteLine($"Тренировка начата {dateTime.ToShortTimeString()}");
            training.TrainingEnded += (sender, dateTime) => Console.WriteLine($"Тренировка окончена {dateTime.ToShortTimeString()}");
            training.Tick += (sender, time) => Console.WriteLine($"Осталось: {time} секунд!");
            training.TakeNextExample += (sender, ex) => Console.WriteLine($"Выдан новый пример! {ex.ToString()}");
            training.StartTraining();
            Console.ReadKey();
        }
    }
}
